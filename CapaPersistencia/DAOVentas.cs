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
    public class DAOVentas
    {
        public bool insertaVentaEnBD(Ventas venta, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[4];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.Int;
                parametro.ParameterName = "@usuario";
                parametro.Value = venta._usuario;

                listaParametros[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.ParameterName = "@cantidad_productos";
                parametro2.Value = venta._cantidad_productos;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.Int;
                parametro3.ParameterName = "@total_venta";
                parametro3.Value = venta._total_venta;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.Int;
                parametro4.ParameterName = "@NroOperacion";
                parametro4.Value = venta._NroOperacion;

                listaParametros[3] = parametro4;

                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "Nueva_Venta", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }
        public Ventas UltimaVenta( out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select MAX(id_venta)as id_venta from ventas";
                DataTable miTabla = cnx.selecData(query, out error);
                Ventas ventaBuscada = new Ventas();

                if (miTabla==null)
                {      
                    return ventaBuscada;
                }
                else
                {                   
                    ventaBuscada._id_venta = int.Parse(miTabla.Rows[0]["id_venta"].ToString());
                    return ventaBuscada;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
