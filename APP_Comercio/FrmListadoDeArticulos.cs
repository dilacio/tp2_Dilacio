using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace APP_Comercio
{
    public partial class frmListadoDeArticulos : Form
    {
        public frmListadoDeArticulos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoDeArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio Art = new ArticuloNegocio();

            List<Articulo> Lista;

            try
            {

                Lista = Art.Listar();

                dgvArticulo.DataSource = Lista;
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
