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
    public partial class frmPersonaAplicandoEncuesta : Form
    {
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
        public frmPersonaAplicandoEncuesta()
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmVerEncuestaAplicar volver = new frmVerEncuestaAplicar();
            volver.Show();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
           continuar();
        }



        #endregion

        #region metodos

        public void continuar()
        {
            if (tbxNombre.Text != "")
            {
                string nombre = tbxNombre.Text;
                int idPersona = iniciarServicio.existeUsuario(nombre);

                if (idPersona >= 0)
                {

                    RepositorioForms.Instancia.personaActual = idPersona;
                    frmAplicarEncuesta aplicar = new frmAplicarEncuesta();
                    aplicar.Show();
                    this.Close();

                }
                else 
                {
                    MessageBox.Show("Parece que no encontramos ninguna persona registrada con este nombre, si no esta registrado vuelva al inicio y crea una cuenta...");
                }
            }
            else
            {
                MessageBox.Show("Debes llenar el campo nombre...");
            }
        }


        #endregion

        private void frmPersonaAplicandoEncuesta_Load(object sender, EventArgs e)
        {

        }
    }
}
