using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoAUTOCOR
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsRepuesto objRepuesto = new ClsRepuesto();
            objRepuesto.Codigo = int.Parse(txtCodigo.Text);
            objRepuesto.Nombre = txtNombre.Text;
            objRepuesto.Marca = cmbMarca.Text;
            objRepuesto.Precio = int.Parse(txtPrecio.Text);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
