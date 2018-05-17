using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;



namespace CapaNegocio
{
    public class NegDetalleVenta
    {
        public void NuevoDetalle(DetalleVenta DVEnta, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(string.Concat(DVEnta._id_venta)))
            {
                msjValida += "El campo Venta viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(string.Concat(DVEnta._id_usuario)))
            {
                msjValida += "El campo Usuario viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(string.Concat(DVEnta._serie_producto)))
            {
                msjValida += "El campo Producto viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(DVEnta._nombre_producto))
            {
                msjValida += "El campo nombre producto viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(string.Concat(DVEnta._cantidad)))
            {
                msjValida += "El campo cantidad viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(string.Concat(DVEnta._valor_unitario)))
            {
                msjValida += "El campo valor unitario viene vacio" + "\n";
            }
            if (msjValida.Equals(""))
            {
               DAODetalleVenta cpop = new DAODetalleVenta();

                bool exito = cpop.insertaDetalleEnBD(DVEnta, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de Ingreso de Detalle Venta " + msjValida;
                }
            }
        }
        public List<DetalleVenta> listardetalles(out string error)
        {
            error = "";
            try
            {
                DAODetalleVenta accde = new DAODetalleVenta();
                return accde.listartodoDetalles(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public DetalleVenta datDetalles(DetalleVenta DV, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(string.Concat(DV._id_venta)))
                {
                    error += "El campo Ventas viene vacio" + "\n";
                }
                if (String.IsNullOrEmpty(string.Concat(DV._id_usuario)))
                {
                    error += "El campo Usuario viene vacio" + "\n";
                }
                if (String.IsNullOrEmpty(string.Concat(DV._serie_producto)))
                {
                    error += "El campo Producto viene vacio" + "\n";
                }

                if (error.Equals(""))
                {
                    DAODetalleVenta operacion = new DAODetalleVenta();
                    DetalleVenta detVen = operacion.datosDetalle(DV, out error);

                    if (detVen == null)
                    {
                        error += "No hay detalle de ventas";
                    }

                    return detVen;
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
    }
}
