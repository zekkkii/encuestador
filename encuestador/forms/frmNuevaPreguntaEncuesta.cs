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
    public partial class frmNuevaPreguntaEncuesta : Form
    {
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public frmNuevaPreguntaEncuesta()
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            guardarContinuar();
        }


        public void guardarContinuar()
        {
            if (tbxTitulo.Text != "")
            {
                RepositorioForms repo = RepositorioForms.Instancia;

                if (repo.cantidadPreguntasTomadas == repo.cantidadpreguntas)
                {
                    iniciarServicio.asignarPreguntaAEncuesta( tbxTitulo.Text);
                    MessageBox.Show("Listo!");

                    frmMenuPrincipal iniciarMenuPrincipal = new frmMenuPrincipal();
                    iniciarMenuPrincipal.Show();
                    this.Close();
                }

                if (repo.cantidadPreguntasTomadas != repo.cantidadpreguntas)
                {
                    iniciarServicio.añadirPregunta(RepositorioForms.Instancia.encuestaActual,tbxTitulo.Text);
                    RepositorioForms.Instancia.cantidadPreguntasTomadas += 1;
                    MessageBox.Show("Escribe la siguiente pregunta...");

                    frmNuevaPreguntaEncuesta nuevaPregunta = new frmNuevaPreguntaEncuesta();
                    nuevaPregunta.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debes llenar el campo del titulo...");
            }
        }
    }
}
