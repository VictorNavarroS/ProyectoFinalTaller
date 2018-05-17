using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaPersistencia
{   
    public class DAODetalleVenta
    {
        public List<DetalleVenta> listartodoDetalles( out string error)
        {
            try
            {
                error = "";
                ConexionBD conecta = new ConexionBD();
                string query = "select * from detalle_venta ";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<DetalleVenta> DetalleVentas = new List<DetalleVenta>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                       DetalleVenta Nombredetalle= new DetalleVenta();
                        Nombredetalle._id_venta = int.Parse(miTabla.Rows[i]["id_venta"].ToString());
                        Nombredetalle._id_usuario = int.Parse(miTabla.Rows[i]["id_usuario"].ToString());
                        Nombredetalle._serie_producto = miTabla.Rows[i]["serie_producto"].ToString();
                        Nombredetalle._nombre_producto = miTabla.Rows[i]["nombre_producto"].ToString();
                        Nombredetalle._cantidad= int.Parse(miTabla.Rows[i]["cantidad"].ToString());
                        Nombredetalle._valor_unitario = int.Parse(miTabla.Rows[i]["valor_unitario"].ToString());
                        DetalleVentas.Add(Nombredetalle);
                    }
                    return DetalleVentas;
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public DetalleVenta datosDetalle(DetalleVenta detalle, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from detalle_venta ";
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
                    DetalleVenta Nombredetalle = new DetalleVenta();
                    Nombredetalle._id_venta = int.Parse(miTabla.Rows[0]["id_venta"].ToString());
                    Nombredetalle._id_usuario = int.Parse(miTabla.Rows[0]["id_usuario"].ToString());
                    Nombredetalle._serie_producto = miTabla.Rows[0]["serie_producto"].ToString();
                    Nombredetalle._nombre_producto = miTabla.Rows[0]["nombre_producto"].ToString();
                    Nombredetalle._cantidad = int.Parse(miTabla.Rows[0]["cantidad"].ToString());
                    Nombredetalle._valor_unitario = int.Parse(miTabla.Rows[0]["valor_unitario"].ToString());
                    

                    return Nombredetalle;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool insertaDetalleEnBD(DetalleVenta inDetalle, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[6];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.Int;
                parametro.ParameterName = "@id_venta";
                parametro.Value = inDetalle._id_venta;

                listaParametros[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.ParameterName = "@id_usuario";
                parametro2.Value = inDetalle._id_usuario;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@serie_producto";
                parametro3.Value = inDetalle._serie_producto;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.VarChar;
                parametro4.ParameterName = "@nombre_producto";
                parametro4.Value = inDetalle._nombre_producto;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.Int;
                parametro5.ParameterName = "@cantidad";
                parametro5.Value = inDetalle._cantidad;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.Int;
                parametro6.ParameterName = "@valor_unitario";
                parametro6.Value = inDetalle._valor_unitario;

                listaParametros[5] = parametro6;


                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "NuevoDetalleVenta", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
