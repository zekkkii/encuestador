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
    public partial class frmVerEncuestaAplicar : Form
    {

        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public frmVerEncuestaAplicar()
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

        private void frmVerEncuestaAplicar_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void btnAplicarEncuesta_Click(object sender, EventArgs e)
        {
            if (RepositorioForms.Instancia.indexSeleccionado >= 0)
            {
                RepositorioForms.Instancia.encuestaActual = RepositorioForms.Instancia.indexSeleccionado;
                frmPersonaAplicandoEncuesta personaEncuestada = new frmPersonaAplicandoEncuesta();
                personaEncuestada.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una encuesta");
            }
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void dgvEncuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.indexSeleccionado = Convert.ToInt32(dgvEncuestas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        #endregion


        #region metodos

        public void cargarDataGrid()
        {
            DataTable data = iniciarServicio.cargarEncuestas();
            dgvEncuestas.DataSource = data;
            dgvEncuestas.ClearSelection();
        }

        #endregion

   
    }
}
