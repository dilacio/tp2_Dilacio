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
    public partial class FrmAgregarArticulo : Form
    {
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio CatNeg = new CategoriaNegocio();
            MarcaNegocio MarNeg = new MarcaNegocio();

            try
            {
                cbxCategoria.DataSource = CatNeg.Listar();
                cbxMarca.DataSource = MarNeg.Listar();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Articulo Art = new Articulo();
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            try
            {
                Art.Nombre = tbxNombre.Text;
                Art.Descripcion = txbDescripcion.Text;
                Art.CodigoArticulo = int.Parse(txbCodArticulo.Text);
                Art.Marca = (Marca)cbxMarca.SelectedItem;
                Art.Categoria = (Categoria)cbxCategoria.SelectedItem;
                Art.Precio = float.Parse(txbPrecio.Text);

                try
                {
                    ArtNeg.Agregar(Art);
                    MessageBox.Show("Registro Agregado con exito!!");
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
