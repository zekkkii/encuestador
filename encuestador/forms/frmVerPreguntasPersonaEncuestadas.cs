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
    public partial class frmVerPreguntasPersonaEncuestadas : Form
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

        public frmVerPreguntasPersonaEncuestadas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            iniciarServicio = new Servicio(connection);
        }

        private void frmVerPreguntasPersonaEncuestadas_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonasEncuestadas verPersonas = new frmPersonasEncuestadas();
            verPersonas.Show();
            RepositorioForms.Instancia.encuestaActual = -1;
            RepositorioForms.Instancia.indexSeleccionado = -1;
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            RepositorioForms.Instancia.encuestaActual = -1;
            RepositorioForms.Instancia.indexSeleccionado = -1;
            this.Close();
        }

        #region metodos

        public void cargarDataGrid()
        {
            DataTable data = iniciarServicio.verRespuestasPersonasEncuestadas(RepositorioForms.Instancia.indexSeleccionado, RepositorioForms.Instancia.encuestaActual);
            dgvEncuestas.DataSource = data;
            dgvEncuestas.ClearSelection();
        }

        #endregion

        
    }
}
