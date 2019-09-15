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

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("update[Articulo] set[Nombre] = @Nombre,[CodigoArticulo] = @CodArt,[Descripcion] = @Descripcion,[ID_Marca] = @ID_Marca,[ID_Categoria] = @ID_Categoria,[Precio] = @Precio where ID = @ID");



                Datos.AgregarParametro("@ID", Art.ID.ToString());
                Datos.AgregarParametro("@Nombre", Art.Nombre);
                Datos.AgregarParametro("@CodArt", Art.CodigoArticulo.ToString());
                Datos.AgregarParametro("@Descripcion", Art.Descripcion);
                Datos.AgregarParametro("@ID_Marca", Art.Marca.ID.ToString());
                Datos.AgregarParametro("@ID_Categoria", Art.Categoria.ID.ToString());
                Datos.AgregarParametro("@Precio", Art.Precio.ToString());

                Datos.Ejecucion_Accion();

                return true;


            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public bool Eliminar(int ID_Borrar)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("update [Negocio].[dbo].[Articulo] set baja = 1 where ID = @ID");
                Datos.AgregarParametro("@ID", ID_Borrar.ToString());

                Datos.Ejecucion_Accion();

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

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("select a.ID, Nombre, a.CodigoArticulo, a.Descripcion, a.Precio, m.Descripcion, c.Descripcion from[Negocio].[dbo].Articulo as a inner join[Negocio].[dbo].Categoria as c on c.ID = a.ID_Categoria inner join Marca as m on a.ID_Marca = m.ID where a.baja = 0 and a.Nombre like '%" + Cadena + "%'");
                Datos.AgregarParametro("@Cadena", Cadena);

                Articulo Aux;

                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Articulo();

                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.CodigoArticulo = Datos.Lector.GetInt32(2);
                    Aux.Descripcion = Datos.Lector.GetString(3);
                    Aux.Precio = Datos.Lector.GetDouble(4);
                    Aux.Marca = new Marca();
                    Aux.Marca.Descripcion = Datos.Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Descripcion = Datos.Lector.GetString(6);

                    Lista.Add(Aux);

                }

                return Lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }


        }

        public bool Agregar(Articulo Artic)
        {
            bool Resultado = false;

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetearQuery("Insert into [Negocio].[dbo].Articulo values(@Nombre,@CodigoArticulo,@Descripcion,@ID_Marca,@ID_Categoria,@Precio,NULL,0)");
                Datos.AgregarParametro("@Nombre", Artic.Nombre);
                Datos.AgregarParametro("@CodigoArticulo", Artic.CodigoArticulo.ToString());
                Datos.AgregarParametro("@Descripcion", Artic.Descripcion);
                Datos.AgregarParametro("@Precio", Artic.Precio.ToString());
                Datos.AgregarParametro("@ID_Marca", Artic.Marca.ID.ToString());
                Datos.AgregarParametro("@ID_Categoria", Artic.Categoria.ID.ToString());

                Datos.EjecutarLector();

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

            AccesoDatos Datos = new AccesoDatos();

            Articulo Aux;

            try
            {
                Datos.SetearQuery("SELECT a.[ID],[Nombre],[CodigoArticulo], a.[Descripcion], a.Precio, Marca.[Descripcion] as Marca,[Categoria].Descripcion as Categoria,[Imagen] FROM[Negocio].[dbo].[Articulo] as a inner join[Negocio].[dbo].[Categoria] on Categoria.ID = a.ID_Categoria inner join Marca on Marca.ID = a.ID_Marca where a.baja = 0");
                Datos.EjecutarLector();

                while (Datos.Lector.Read())
                {
                    Aux = new Articulo();
                    Aux.ID = Datos.Lector.GetInt32(0);
                    Aux.Nombre = Datos.Lector.GetString(1);
                    Aux.CodigoArticulo = Datos.Lector.GetInt32(2);
                    Aux.Descripcion = Datos.Lector.GetString(3);
                    Aux.Precio = Datos.Lector.GetDouble(4);
                    Aux.Marca = new Marca();
                    Aux.Marca.Descripcion = Datos.Lector.GetString(5);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Descripcion = Datos.Lector.GetString(6);
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
                Datos.CerrarConexion();

            }
        }
    }
}
