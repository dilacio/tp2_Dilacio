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
    public partial class FrmEliminarArticulo : Form
    {
        public FrmEliminarArticulo()
        {
            InitializeComponent();
        }

        private void PctCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            try
            {
                cbxArticulo.DataSource = ArtNeg.Listar();
                
            }
            catch (Exception Ex)
            {

                throw Ex;
            }


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            dgvDetalleArticulo.DataSource = ArtNeg.Buscar(cbxArticulo.Text);
                     
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            try
            {
                bool Resultado = ArtNeg.Eliminar(Convert.ToInt32(dgvDetalleArticulo.Rows[0].Cells[0].Value));

                if (Resultado)
                {
                    MessageBox.Show("Registro dado de baja correctamente");
                    cbxArticulo.DataSource = ArtNeg.Listar();
                }
            }
            catch (Exception Ex)
            {

                throw Ex;  
            }
            
        }
    }
}
