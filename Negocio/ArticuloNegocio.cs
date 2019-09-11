using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public bool Modificar(Articulo Art)
        {
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();

            try
            {
                Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=Negocio; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "update [Negocio].[dbo].[Articulo] set [Nombre] = @Nombre,[CodigoArticulo]= @CodArt,[Descripcion] = @Descripcion,[ID_Marca] = @ID_Marca,[ID_Categoria]= @ID_Categoria,[Precio] = @Precio where ID = @ID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@ID", Art.ID);
                Comando.Parameters.AddWithValue("@Nombre", Art.Nombre);
                Comando.Parameters.AddWithValue("@CodArt", Art.CodigoArticulo);
                Comando.Parameters.AddWithValue("@Descripcion", Art.Descripcion);
                Comando.Parameters.AddWithValue("@ID_Marca", Art.Marca.ID);
                Comando.Parameters.AddWithValue("@ID_Categoria", Art.Categoria.ID);
                Comando.Parameters.AddWithValue("@Precio", Art.Precio);

                Comando.Connection = Conexion;

                Conexion.Open();

                Comando.ExecuteNonQuery();

                return true;


            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public bool Eliminar(int ID_Borrar)
        {
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();

            try
            {
                Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=Negocio; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "delete from [Negocio].[dbo].Articulo where ID = @ID_Borrar";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@ID_Borrar", ID_Borrar);

                Comando.Connection = Conexion;

                Conexion.Open();

                Comando.ExecuteNonQuery();

                return true;


            }
            catch (Exception Ex)
            {

                throw Ex;
            }

            

        }

        public List<Articulo> Buscar(string Cadena)
        {
            List<Articulo> Lista = new List<Articulo>();

            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            

            try
            {
                Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=Negocio; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select a.ID,Nombre,a.CodigoArticulo, a.Descripcion, a.Precio, m.Descripcion, c.Descripcion from[Negocio].[dbo].Articulo as a inner join[Negocio].[dbo].Categoria as c on c.ID = a.ID_Categoria inner join Marca as m on a.ID_Marca = m.ID where a.Nombre like '%"+Cadena + "%'";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@Cadena", Cadena);
                Articulo Aux;

                Comando.Connection = Conexion;
                Conexion.Open();

                Lector = Comando.ExecuteReader();

                while(Lector.Read())
                {
                    Aux = new Articulo();

                    Aux.ID = Lector.GetInt32(0);
                    Aux.Nombre = Lector.GetString(1);
                    Aux.CodigoArticulo = Lector.GetInt32(2);
                    Aux.Descripcion = Lector.GetString(3);
                    Aux.Precio = Lector.GetDouble(4);
                    Aux.Marca = new Marca();
                    Aux.Marca.Descripcion = Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Descripcion = Lector.GetString(6);

                    Lista.Add(Aux);

                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }


        }

        public bool Agregar( Articulo Artic)
        {
            bool Resultado = false;

            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();

            try
            {
                Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=POKEDEX_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Insert into [Negocio].[dbo].Articulo values(@Nombre,@CodigoArticulo,@Descripcion,@ID_Marca,@ID_Categoria,@Precio,'')";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@Nombre",Artic.Nombre);
                Comando.Parameters.AddWithValue("@CodigoArticulo", Artic.CodigoArticulo);
                Comando.Parameters.AddWithValue("@Descripcion", Artic.Descripcion);
                Comando.Parameters.AddWithValue("@Precio", Artic.Precio);
                Comando.Parameters.AddWithValue("@ID_Marca", Artic.Marca.ID);
                Comando.Parameters.AddWithValue("@ID_Categoria", Artic.Categoria.ID);


                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();

                return Resultado;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            

        }
        
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();

            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;

            Articulo Aux;

            try
            {
                Conexion.ConnectionString = "data source=NBBASAR605\\SQLEXPRESS; initial catalog=Negocio; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;

                Comando.CommandText = "SELECT a.[ID],[Nombre],[CodigoArticulo],a.[Descripcion],a.Precio,Marca.[Descripcion] as Marca,[Categoria].Descripcion as Categoria,[Imagen] FROM[Negocio].[dbo].[Articulo] as a inner join[Negocio].[dbo].[Categoria] on Categoria.ID = a.ID_Categoria inner join Marca on Marca.ID = a.ID_Marca";
                Comando.Connection = Conexion;

                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Lector.GetInt32(0);
                    Aux.Nombre = Lector.GetString(1);
                    Aux.CodigoArticulo = Lector.GetInt32(2);
                    Aux.Descripcion = Lector.GetString(3);
                    Aux.Precio = Lector.GetDouble(4);
                    Aux.Marca = new Marca();
                    Aux.Marca.Descripcion = Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Descripcion = Lector.GetString(6);
                    Lista.Add(Aux);
                }
                    return Lista;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Conexion.Close();
            }
        }
    }
}
