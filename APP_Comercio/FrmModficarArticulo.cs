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
    public partial class FrmModficarArticulo : Form
    {
        public FrmModficarArticulo()
        {
            InitializeComponent();
        }

        private void TsBarra_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModficarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            CategoriaNegocio CatNeg = new CategoriaNegocio();
            MarcaNegocio MarNeg = new MarcaNegocio();

            Articulo Art;
            try
            {
                cbxArticulo.DataSource = ArtNeg.Listar();
                cbxCategoria.DataSource = CatNeg.Listar();
                cbxMarca.DataSource = MarNeg.Listar(); 


                Art = (Articulo)cbxArticulo.SelectedItem;

                tbxNombre.Text = Art.Nombre;
                txbCodArticulo.Text = Art.CodigoArticulo.ToString();
                txbDescripcion.Text = Art.Descripcion;
                txbPrecio.Text = Art.Precio.ToString();
                cbxCategoria.SelectedItem = Art.Categoria.Descripcion;
                cbxMarca.SelectedItem = Art.Marca.Descripcion;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            Articulo Art;

            try
            {
                Art = (Articulo)cbxArticulo.SelectedItem;

                Art.Nombre = tbxNombre.Text;
                Art.CodigoArticulo = Convert.ToInt32(txbCodArticulo.Text);
                Art.Descripcion = txbDescripcion.Text;
                Art.Precio = Convert.ToDouble(txbPrecio.Text);
                Art.Marca = (Marca)cbxMarca.SelectedItem;
                Art.Categoria = (Categoria)cbxCategoria.SelectedItem;

                ArtNeg.Modificar(Art);

                MessageBox.Show("Registro modificado");

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }


           
        }
    }
}
