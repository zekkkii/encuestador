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

namespace encuestador.forms
{
    public partial class frmPersonasEncuestadas : Form
    {

        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }

        public frmPersonasEncuestadas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Servicio(connection);
        }
        #region eventos
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
        private void frmPersonasEncuestadas_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void dgvEncuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.indexSeleccionado = Convert.ToInt32(dgvEncuestas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerEncuesta volverVerEncuesta = new frmVerEncuesta();
            volverVerEncuesta.Show();
            this.Close();
        }


        #endregion

        #region metodos

        public void seleccionar()
        {
            if (RepositorioForms.Instancia.indexSeleccionado >= 0)
            {
            
                frmVerPreguntasPersonaEncuestadas VerRespuestas = new frmVerPreguntasPersonaEncuestadas();
                VerRespuestas.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una encuesta");
            }
        }

        public void cargarDataGrid()
        {
            DataTable data = iniciarServicio.verPersonasEncuestadas(RepositorioForms.Instancia.indexSeleccionado);
            dgvEncuestas.DataSource = data;
            dgvEncuestas.ClearSelection();
        }

        #endregion

      
    }
}
