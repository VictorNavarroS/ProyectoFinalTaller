using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;

namespace CapaNegocio
{
    public class NegVentas
    {
        public Ventas UltVenta( out string error)
        {
             try
             {
                error = "";
                if (error.Equals(""))
                {
                    DAOVentas venDao = new DAOVentas();
                    Ventas venta= venDao.UltimaVenta(out error) ;
                    
                    if (venta == null)
                    {
                        error += "No hay datos";
                    }
                    return venta;
                }
                else
                {
                    return null;
                }
             }
                catch (Exception ex)
                {
                error = ex.Message;                
                return null;
                 }


        }
        public void VentaNuevo(Ventas venta, out string msjValida)
        {
            msjValida = "";

            if (venta._usuario==0)
            {
                msjValida = "El campo Usuario viene vacio" + "\n";
            }

            if (venta._NroOperacion==0)
            {
                msjValida += "El campo Numro de Operacion viene vacio" + "\n";
            }

            if (venta._cantidad_productos==0)
            {
                msjValida += "No se Agrego ningun producto ala venta" + "\n";
            }

            if (venta._total_venta==0)
            {
                msjValida += "El campo Total venta esta vacio" + "\n";
            }            

            if (msjValida.Equals(""))
            {
                DAOVentas cpVenta = new DAOVentas();

                bool exito = cpVenta.insertaVentaEnBD(venta, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de Ingreso de la Venta " + msjValida;
                }
            }
        }
    }
}
