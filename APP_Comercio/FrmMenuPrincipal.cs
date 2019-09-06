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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmBusquedaAticulo BusquedaArticulos = new FrmBusquedaAticulo();

            BusquedaArticulos.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmListadoDeArticulos ListadoArticulos = new frmListadoDeArticulos();

            ListadoArticulos.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo DetalleArticulo = new FrmDetalleArticulo();

            DetalleArticulo.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmModficarArticulo ModificarArticulo = new FrmModficarArticulo();

            ModificarArticulo.Show();
        }

        private void FrmPrincipal_MouseLeave(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo AgregarArticulo = new FrmAgregarArticulo();
            AgregarArticulo.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            frmListadoDeArticulos Listado = new frmListadoDeArticulos();

            Listado.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FrmBusquedaAticulo Busqueda = new FrmBusquedaAticulo();

            Busqueda.Show();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            FrmDetalleArticulo Detalle = new FrmDetalleArticulo();

            Detalle.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmModficarArticulo Modificar = new FrmModficarArticulo();
            Modificar.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            FrmEliminarArticulo EliminarArticulo = new FrmEliminarArticulo();
            EliminarArticulo.Show();
        }
    }
}
