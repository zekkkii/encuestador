using Logiclayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.models;

namespace encuestador.forms
{
    public partial class frmAplicarEncuesta : Form
    {

        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public frmAplicarEncuesta()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Servicio(connection);
        }


        #region desactivar boton cerrar
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        #region eventos
        private void frmAplicarEncuesta_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }
        private void dgvEncuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.indexSeleccionado = Convert.ToInt32(dgvPreguntas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerEncuestaAplicar volver = new frmVerEncuestaAplicar();
            volver.Show();


            RepositorioForms.Instancia.encuestaActual = -1;
            RepositorioForms.Instancia.indexSeleccionado = -1;
            this.Close();
        }

        private void btnGuardarRespuestas_Click(object sender, EventArgs e)
        {
            guardar();
        }

        #endregion



        #region metodos

        public void guardar()
        {
           
            
            List<Respuesta> respuestas = new List<Respuesta>();
            for (int i = 0; i < dgvPreguntas.RowCount; i++)
            {
                respuestas.Add(new Respuesta()
                { idPregunta = (int)dgvPreguntas.Rows[i].Cells[0].Value, respuesta = (string)dgvPreguntas.Rows[i].Cells[2].Value });
            }

            bool fueIntroducido = iniciarServicio.introducirRespuestaPregunta(RepositorioForms.Instancia.personaActual, respuestas);

            if (fueIntroducido)
            {
                MessageBox.Show("Datos Guardados!!!");
                frmVerEncuestaAplicar volver = new frmVerEncuestaAplicar();
                volver.Show();
                RepositorioForms.Instancia.personaActual = -1;
                RepositorioForms.Instancia.indexSeleccionado = -1;
                RepositorioForms.Instancia.encuestaActual = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Parece que hubo un error, intenta luego...");
                frmVerEncuestaAplicar volver = new frmVerEncuestaAplicar();
                volver.Show();
                RepositorioForms.Instancia.personaActual = -1;
                RepositorioForms.Instancia.indexSeleccionado = -1;
                RepositorioForms.Instancia.encuestaActual = -1;
                this.Close();
            }
            
           
            //rellenar aqui 
        }

        #endregion



        #region utilidades

        public void cargarDataGrid()
        {
            int encuestaActual = RepositorioForms.Instancia.encuestaActual;
            DataTable data = iniciarServicio.cargarPreguntas(encuestaActual);
            data.Columns.Add(new DataColumn("Escribe tu respuesta", typeof(string)));
            dgvPreguntas.DataSource = data;
            dgvPreguntas.Columns[0].ReadOnly = true;
            dgvPreguntas.Columns[1].ReadOnly = true;
            dgvPreguntas.ClearSelection();
        }
        #endregion


    }
}
