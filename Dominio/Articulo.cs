using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int CodigoArticulo { get; set; }
        public int Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public float Precio { get; set; }
        public string Imagen { get; set; }
    }
}
