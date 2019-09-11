using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> Listar()
        {
            List<Categoria> Categorias = new List<Categoria>();
            SqlDataReader Lector;
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            Categoria Aux;
            

            try
            {
               Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=Negocio; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;

                Comando.CommandText = "select ID, Descripcion from [Negocio].[dbo].Categoria";
               Comando.Connection = Conexion;

                    Conexion.Open();
                    Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Aux = new Categoria((int)Lector["ID"], (string)Lector["Descripcion"]);


                    Categorias.Add(Aux);
                }

                return Categorias;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }


        }

    }
}
