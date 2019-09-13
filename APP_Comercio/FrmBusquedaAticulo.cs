using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace APP_Comercio
{
    public partial class FrmBusquedaAticulo : Form
    {
        public FrmBusquedaAticulo()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBusquedaAticulo_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            try
            {
                 
                dgvArticulo.DataSource = ArtNeg.Buscar(txbCadenaBuscar.Text); ;
                dgvArticulo.Columns[0].Visible = false;
                dgvArticulo.Columns[3].Visible = false;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
