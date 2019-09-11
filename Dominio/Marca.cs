using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public Marca() { }

        public Marca (int id, string desc)
        {
            ID = id;
            Descripcion = desc;

        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
