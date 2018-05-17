using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;


namespace CapaPersistencia
{
    public class DAOProductos
    {
        public Productos datosProductos(Productos producto, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from productos where serie='" + producto._serie + "';";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return null;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    Productos productoEncontrado = new Productos();
                    productoEncontrado._nombre = miTabla.Rows[0]["nombre"].ToString();
                    productoEncontrado._descripcion = miTabla.Rows[0]["descripcion"].ToString();
                    productoEncontrado._estadoProducto = bool.Parse(miTabla.Rows[0]["estado"].ToString());
                    productoEncontrado._stock = int.Parse(miTabla.Rows[0]["stock"].ToString());
                    productoEncontrado._stockMinimo = int.Parse(miTabla.Rows[0]["stock_minimo"].ToString());
                    productoEncontrado._ubicacion = miTabla.Rows[0]["ubicacion"].ToString();
                    productoEncontrado._valorCompra = int.Parse(miTabla.Rows[0]["valor_compra"].ToString());
                    productoEncontrado._valorVenta = int.Parse(miTabla.Rows[0]["valor_venta"].ToString());
                    productoEncontrado._proveedor = int.Parse(miTabla.Rows[0]["proveedor"].ToString());

                    return productoEncontrado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool insertaProductoBD(Productos producto, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[9];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.VarChar;
                parametro.ParameterName = "@serie";
                parametro.Value = producto._serie;

                listaParametros[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre";
                parametro2.Value = producto._nombre;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@descripcion";
                parametro3.Value = producto._descripcion;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.Bit;
                parametro4.ParameterName = "@estado";
                parametro4.Value = producto._estadoProducto;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.Int;
                parametro5.ParameterName = "@stock";
                parametro5.Value = producto._stock;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.Int;
                parametro6.ParameterName = "@stockMin";
                parametro6.Value = producto._stockMinimo;

                listaParametros[5] = parametro6;

                SqlParameter parametro7 = new SqlParameter();
                parametro7.SqlDbType = SqlDbType.VarChar;
                parametro7.ParameterName = "@ubicacion";
                parametro7.Value = producto._ubicacion;

                listaParametros[6] = parametro7;

                SqlParameter parametro8 = new SqlParameter();
                parametro8.SqlDbType = SqlDbType.Int;
                parametro8.ParameterName = "@valorCompra";
                parametro8.Value = producto._valorCompra;

                listaParametros[7] = parametro8;

                SqlParameter parametro9 = new SqlParameter();
                parametro9.SqlDbType = SqlDbType.Int;
                parametro9.ParameterName = "@proveedor";
                parametro9.Value = producto._proveedor;

                listaParametros[8] = parametro9;


                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "validaRegistroProducto", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }

        public List<Productos> listarTodosLosProductos(out string msjValida)
        {
            try
            {
                msjValida = "";
                ConexionBD conexion = new ConexionBD();
                DataTable miTabla = conexion.selecData("select * from productos ", out msjValida);
                List<Productos> listaDeTodosLosProductos = new List<Productos>();

                for (int i = 0; i < miTabla.Rows.Count; i++)
                {
                    Productos producto = new Productos();

                    producto._serie = miTabla.Rows[i]["serie"].ToString();
                    producto._nombre = miTabla.Rows[i]["nombre"].ToString();
                    producto._descripcion = miTabla.Rows[i]["descripcion"].ToString();
                    producto._estadoProducto = bool.Parse(miTabla.Rows[i]["estado"].ToString());
                    producto._stock = int.Parse(miTabla.Rows[i]["stock"].ToString());
                    producto._stockMinimo = int.Parse(miTabla.Rows[i]["stock_minimo"].ToString());
                    producto._valorVenta = int.Parse(miTabla.Rows[i]["valor_venta"].ToString());
                    producto._ubicacion = miTabla.Rows[i]["ubicacion"].ToString();
                    producto._valorCompra = int.Parse(miTabla.Rows[i]["valor_compra"].ToString());
                    producto._proveedor = int.Parse(miTabla.Rows[i]["proveedor"].ToString());

                    listaDeTodosLosProductos.Add(producto);
                }

                return listaDeTodosLosProductos;
            }
            catch (SqlException ex)
            {
                msjValida = ex.Message;
                return null;
            }

        }

        public bool actualizaProducto(Productos producto, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();
                /*
                string sqlQuery = "insert into alumnos (rut,nombre1,nombre2,ape1,ape2,edad,matricula,semestre,esRepresentante) values ('" + alumno._rut + "','" + alumno._nombre1 + "','" + alumno._nombre_2 + "'," +
                "'" + alumno._apellido_p + "','" + alumno._apellido_m + "'," + alumno._edad + ",'" + alumno.Matricula + "'," + alumno.SemestreActual + ",'" + alumno.EsRepresentante + "');";
                */

                int intExito = 0;
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter("validaActualizacionProductos", conexion.getConexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlAdaptador.SelectCommand.Parameters.Add("@serie", SqlDbType.VarChar).Value = producto._serie;
                sqlAdaptador.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = producto._nombre;
                sqlAdaptador.SelectCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = producto._descripcion;
                sqlAdaptador.SelectCommand.Parameters.Add("@valorCompra", SqlDbType.Int).Value = producto._valorCompra;
                sqlAdaptador.SelectCommand.Parameters.Add("@stock", SqlDbType.Int).Value = producto._stock;
                sqlAdaptador.SelectCommand.Parameters.Add("@stockMin", SqlDbType.Int).Value = producto._stockMinimo;
                sqlAdaptador.SelectCommand.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = producto._ubicacion;
                sqlAdaptador.SelectCommand.Parameters.Add("@proveedor", SqlDbType.Int).Value = producto._proveedor;
                sqlAdaptador.SelectCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = producto._estadoProducto;
                conexion.getConexion.Open();
                intExito = sqlAdaptador.SelectCommand.ExecuteNonQuery();
                conexion.getConexion.Close();

                if (intExito > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }
        public List<Productos> listarLosProductos(string consulta, out string msjValida)
        {
            try
            {
                msjValida = "";
                ConexionBD conexion = new ConexionBD();
                DataTable miTabla = conexion.selecData("select * from productos " + consulta + ";", out msjValida);
                List<Productos> listaDeTodosLosProductos = new List<Productos>();

                for (int i = 0; i < miTabla.Rows.Count; i++)
                {
                    Productos producto = new Productos();

                    producto._serie = miTabla.Rows[i]["serie"].ToString();
                    producto._nombre = miTabla.Rows[i]["nombre"].ToString();
                    producto._descripcion = miTabla.Rows[i]["descripcion"].ToString();
                    producto._estadoProducto = bool.Parse(miTabla.Rows[i]["estado"].ToString());
                    producto._stock = int.Parse(miTabla.Rows[i]["stock"].ToString());
                    producto._stockMinimo = int.Parse(miTabla.Rows[i]["stock_minimo"].ToString());
                    producto._valorVenta = int.Parse(miTabla.Rows[i]["valor_venta"].ToString());
                    producto._ubicacion = miTabla.Rows[i]["ubicacion"].ToString();
                    producto._valorCompra = int.Parse(miTabla.Rows[i]["valor_compra"].ToString());
                    producto._proveedor = int.Parse(miTabla.Rows[i]["proveedor"].ToString());

                    listaDeTodosLosProductos.Add(producto);
                }

                return listaDeTodosLosProductos;
            }
            catch (SqlException ex)
            {
                msjValida = ex.Message;
                return null;
            }

        }
    }
}
