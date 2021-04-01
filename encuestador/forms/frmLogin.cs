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
using System.Configuration;
using System.Data.SqlClient;
using Logiclayer;
using DataBase.models;

namespace encuestador.forms
{
    public partial class frmLogin : Form
    {
        public Servicio servicio { get; set; }
            
        public frmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicio = new Servicio(connection);
        }

        #region eventos

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text != "" && tbxUsuario.Text != "")
            {
                iniciarSesion();
            }
            else
            {
                MessageBox.Show("Debes completar todos los campos");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }
        #endregion

        #region metodos
        private void iniciarSesion()
        {
            Credenciales userPassword = new Credenciales() { usuario= tbxUsuario.Text, password =tbxPassword.Text};
           bool data= servicio.login(userPassword);
            if (data)
            {
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Datos incorrectos, si no tienes cuenta crea una..."); }
        }
        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      