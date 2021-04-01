using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logiclayer;
using DataBase.models;
using System.Configuration;
using System.Data.SqlClient;

namespace encuestador.forms
{
    public partial class frmRegistro : Form
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
        public Servicio servicio;
        public frmRegistro()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicio = new Servicio(connection);
        }


        #region eventos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text != "" && tbxApellido.Text != "" 
                && tbxUsuario.Text != "" &&
                tbxPassword.Text != "" &&
                tbxConfirmarPassword.Text != "")
            {
                if (tbxPassword.Text == tbxConfirmarPassword.Text)
                {
                    registrar();
                }
                else
                {
                    MessageBox.Show("Los passwords deben coincidir...");
                }
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            RepositorioForms.Instancia.login.Show();
            this.Close();
        }
        #endregion

        #region metodos

        private void  registrar()
        {

            Usuario user = new Usuario(
                tbxNombre.Text,
                tbxApellido.Text,
                tbxUsuario.Text,
                tbxPassword.Text
                );


           bool respuesta= servicio.registro(user);

            if (respuesta)
            {
                MessageBox.Show("Creado satisfactoriamente");
            }
            else 
            {
                MessageBox.Show("parece que hay un usuario con este nombre, intenta otro");
            }

        }
        #endregion

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
