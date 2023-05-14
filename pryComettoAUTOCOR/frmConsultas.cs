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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            clsRepuesto objRepuesto = new clsRepuesto();
            objRepuesto.cargarRepuestos(cmbMarca, optNacional, optImportado, optAmbos, dgvRepuestos);
        }
    }
}
