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

        public bool Valida_campos ()
        {
            bool ValCod, ValNombre, ValDesc, ValPrecio;

            try
            {
                //Codigo de Articulo
                if (string.IsNullOrEmpty(txbCodArticulo.Text))
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
                if (string.IsNullOrEmpty(txbDescripcion.Text))
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
                if (string.IsNullOrEmpty(txbPrecio.Text ))
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
                if (string.IsNullOrEmpty(tbxNombre.Text))
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Articulo Art = new Articulo();
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            if (Valida_campos())
            {
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
                        this.Close();
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
            else
            {
                MessageBox.Show("Hay campos incompletos o mal cargados");
            }
            
        }
    }
}
