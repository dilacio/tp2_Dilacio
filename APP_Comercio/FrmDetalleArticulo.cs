using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Comercio
{
    public partial class FrmDetalleArticulo : Form
    {
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsBarra_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
