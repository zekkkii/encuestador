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
    public partial class frmMenuPrincipal : Form
    {
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection {get;set;}


        public frmMenuPrincipal()
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
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (RepositorioForms.Instancia.indexSeleccionado >= 0)
            {
                frmEditarEncuesta editarEncuesta = new frmEditarEncuesta();
                editarEncuesta.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Debes seleccionar una encuesta");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (RepositorioForms.Instancia.indexSeleccionado >= 0)
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar esta encuesta?", "Confirmacion"
                      , MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool fueExitoso = iniciarServicio.borrarEncuesta(RepositorioForms.Instancia.indexSeleccionado);
                    if (fueExitoso)
                    {
                        MessageBox.Show("Borrado satisfactoriamente!");
                        cargarDataGrid();
                        // aqui reseteo en index seleccionado
                        RepositorioForms.Instancia.indexSeleccionado = -1;
                    }
                    else
                    {
                        MessageBox.Show("Al parecer hubo un error, encuesta no eliminada...");
                        // aqui reseteo en index seleccionado
                        RepositorioForms.Instancia.indexSeleccionado = -1;
                    }
                }
                else 
                {
                    dgvEncuestas.ClearSelection();
                }
            }
            else 
            {
                MessageBox.Show("Debes seleccionar una encuesta");
            }

        }

            private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            RepositorioForms.Instancia.login.Show();
        }

        private void dgvEncuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                RepositorioForms.Instancia.indexSeleccionado = Convert.ToInt32(dgvEncuestas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void crearNuevaEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaEncuesta nuevaEncuesta = new frmNuevaEncuesta();
            nuevaEncuesta.Show();
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
