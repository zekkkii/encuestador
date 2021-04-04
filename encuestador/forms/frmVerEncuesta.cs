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
using encuestador.forms;
using Logiclayer;

namespace encuestador
{
    public partial class frmVerEncuesta : Form
    {

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

        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }

        public frmVerEncuesta()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Servicio(connection);
        }
        #region metodos
        private void frmVerEncuesta_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }


        private void dgvEncuestas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.indexSeleccionado = Convert.ToInt32(dgvEncuestas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnVerEncuesta_Click(object sender, EventArgs e)
        {
            if (RepositorioForms.Instancia.indexSeleccionado >= 0)
            {
                RepositorioForms.Instancia.encuestaActual = RepositorioForms.Instancia.indexSeleccionado;
                frmPersonasEncuestadas personasEncuestadas = new frmPersonasEncuestadas();
                personasEncuestadas.Show();
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

            RepositorioForms.Instancia.encuestaActual = -1;
            RepositorioForms.Instancia.indexSeleccionado = -1;

            this.Close();

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
