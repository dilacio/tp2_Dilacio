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
        public bool Valida_campos()
        {
            bool ValCod, ValNombre, ValDesc, ValPrecio;

            try
            {
                //Codigo de Articulo
                if (txbCodArticulo.Text == "")
                {
                    ValCod = false;
                    txbCodArticulo.BackColor = Color.Red;
                }
                else
                {
                    ValCod = true;
                    txbCodArticulo.BackColor = Color.White;
                }
                //Descripcion
                if (txbDescripcion.Text == "")
                {
                    ValDesc = false;
                    txbDescripcion.BackColor = Color.Red;
                }
                else
                {
                    ValDesc = true;
                    txbDescripcion.BackColor = Color.White;
                }
                //Precio
                if (txbPrecio.Text == "")
                {
                    ValPrecio = false;
                    txbPrecio.BackColor = Color.Red;
                }
                else
                {
                    ValPrecio = true;
                    txbPrecio.BackColor = Color.White;
                }
                //Nombre
                if (tbxNombre.Text == "")
                {
                    ValNombre = false;
                    tbxNombre.BackColor = Color.Red;
                }
                else
                {
                    ValNombre = true;
                    tbxNombre.BackColor = Color.White;
                }
                //Verifico que todas las validaciones hayan sido true
                if (ValPrecio && ValNombre && ValCod && ValDesc)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }
        private void Button4_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            Articulo Art;

            if (Valida_campos())
            {
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
                    this.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hay campos incompletos o mal cargados");
            }
        }
    }
}
