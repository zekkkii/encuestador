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
using Logiclayer;

namespace encuestador.forms
{
    public partial class frmNuevaEncuesta : Form
    {
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public frmNuevaEncuesta()
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
        private void frmNuevaEncuesta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void btnCrearEncuesta_Click(object sender, EventArgs e)
        {
            crearEncuesta();
        }
        #endregion

        #region metodos
        public void crearEncuesta()
        {

            if (tbxTitulo.Text != "")
            {
                iniciarServicio.añadirEncuesta(tbxTitulo.Text);
                
                RepositorioForms.Instancia.cantidadpreguntas = (int)nudNumeroPreguntas.Value;
                RepositorioForms.Instancia.cantidadPreguntasTomadas = 1;

                frmNuevaPreguntaEncuesta nuevaPregunta = new frmNuevaPreguntaEncuesta();
                nuevaPregunta.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes llenar el campo del titulo...");
            }
        }
        #endregion

      
    }
}
