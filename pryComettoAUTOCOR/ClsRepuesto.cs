﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoAUTOCOR
{
    internal class ClsRepuesto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public string Origen { get; set; }

        public string Consultar()
        {
            return "Código: " + Codigo + "\nNombre: " + Nombre + "\nMarca: " + Marca + "\nPrecio: " + Precio + "\nOrigen: " + Origen;
        }
    }
}

