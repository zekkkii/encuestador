using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encuestador.forms
{
    public partial class frmNuevaPreguntaEncuesta : Form
    {
        public frmNuevaPreguntaEncuesta()
        {
            InitializeComponent();
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
            if (tbxTitulo.Text != "")
            {
               // continuar
            }
            else
            {
                MessageBox.Show("Debes llenar el campo del titulo...");
            }
        }
    }
}
