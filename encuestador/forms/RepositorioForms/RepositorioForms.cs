﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encuestador.forms
{
    public class RepositorioForms
    {
        public static RepositorioForms Instancia { get; } = new RepositorioForms();
        public frmLogin login  = new frmLogin();
        public int indexSeleccionado = -1;
    }
}
