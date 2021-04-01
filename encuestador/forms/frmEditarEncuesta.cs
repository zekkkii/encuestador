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
    public partial class frmEditarEncuesta : Form
    {
        public Servicio iniciarServicio { get; set; }
        public SqlConnection connection { get; set; }
      

        public frmEditarEncuesta()
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
        private void frmEditarEncuesta_Load(object sender, EventArgs e)
        {         
            cargarDataGrid();
            dgvPreguntas.ClearSelection();
          
        }

        private void dgvEncuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                RepositorioForms.Instancia.indexSeleccionado = Convert.ToInt32(dgvPreguntas.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnGuardar.Visible = true;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            añadir();           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();     
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();

            //esto setea el index seleccionado a -1 si es que se selecciono algumn item del data grid
            RepositorioForms.Instancia.indexSeleccionado = -1;
            RepositorioForms.Instancia.encuestaActual = -1;
            this.Close();
        }


        #endregion

        #region metodos
        public void  añadir()
        {
            if (iniciarServicio.añadirPregunta(RepositorioForms.Instancia.encuestaActual, tbxPregunta.Text))
            {
                MessageBox.Show("Añadido satisfactoriamente");
                tbxPregunta.Text = "";

                RepositorioForms.Instancia.indexSeleccionado = -1;
               cargarDataGrid();
            }
            else
            {
                MessageBox.Show("No se introdujo la pregunta, al parecer sucedio algo inesperado...");
            }
        }

        public void eliminar()
        {

            if (RepositorioForms.Instancia.indexSeleccionado >= 0)
            {
                //obtengo el valor seleccionado para asi luego usar la variable y mejorar la legibilidad del codigo
                int index = RepositorioForms.Instancia.indexSeleccionado;

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar esta pregunta?", "Confirmacion"
                      , MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool fueExitoso = iniciarServicio.borrarPregunta(index);
                    if (fueExitoso)
                    {
                        MessageBox.Show("Borrado satisfactoriamente!");
                        cargarDataGrid();

                        RepositorioForms.Instancia.indexSeleccionado = -1;
                         btnGuardar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Al parecer hubo un error, encuesta no eliminada...");
                       
                    }
                }
                else
                {
                    dgvPreguntas.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una encuesta");
            }
        }

        public void guardar()
        {
            //obtengo el valor seleccionado para asi luego usar la variable y mejorar la legibilidad del codigo
           int index = RepositorioForms.Instancia.indexSeleccionado;

            DialogResult respuesta = MessageBox.Show("Esta seguro que desea actualizar la pregunta con el id: " + index + "?", "Confirmacion"
                    , MessageBoxButtons.OKCancel);

            if (respuesta == DialogResult.OK)
            {
                iniciarServicio.editarPregunta(index, tbxPregunta.Text);
                tbxPregunta.Text = "";
                btnGuardar.Visible = false;
               
                cargarDataGrid();
            }
        }
#endregion


#region utilidades

public void cargarDataGrid()
        {
            int encuestaActual = RepositorioForms.Instancia.encuestaActual;
            DataTable data = iniciarServicio.cargarPreguntas(encuestaActual);
            dgvPreguntas.DataSource = data;
            dgvPreguntas.ClearSelection();
        }



        #endregion

       
    }
}
