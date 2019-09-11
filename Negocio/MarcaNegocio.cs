using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> Listar()
        {
            List<Marca> Marcas = new List<Marca>();
            SqlDataReader Lector;
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            Marca Aux;


            try
            {
                Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=Negocio; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;

                Comando.CommandText = "select ID, Descripcion from [Negocio].[dbo].Marca";
                Comando.Connection = Conexion;

                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Aux = new Marca((int)Lector["ID"], (string)Lector["Descripcion"]);


                    Marcas.Add(Aux);
                }

                return Marcas;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }


        }
    }
}
