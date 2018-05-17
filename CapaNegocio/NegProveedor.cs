using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;


namespace CapaNegocio
{
    public class NegProveedor
    {
        public List<Proveedor> listarLosProveedores(out string error)
        {
            error = "";
            try
            {
                DAOProveedor accprov = new DAOProveedor();
                return accprov.listarTodosProveedores(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
        public Proveedor datosProv(Proveedor proveedor, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(proveedor._nombreProveedor))
                {
                    error += "Debe ingresar un proveedor valido";
                }

                if (error.Equals(""))
                {
                    DAOProveedor provdao = new DAOProveedor();
                    Proveedor proveedor2 = provdao.datosProv(proveedor, out error);

                    if (proveedor2 == null)
                    {
                        error += "No hay datos del Proveedor";
                    }

                    return proveedor2;
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
        public void actualizaProv(Proveedor proveedor, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(proveedor._nombreProveedor))
            {
                msjValida = "El campo nombre proveedor viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(proveedor._telefonoContacto)))
            {
                msjValida += "El campo Telefono Contacto viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(proveedor._correoContacto))
            {
                msjValida = "El campo Correo Contacto viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOProveedor cpProveedor = new DAOProveedor();

                bool exito = cpProveedor.actualizaProv(proveedor, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de actualización del proveedor nombre " + proveedor._nombreProveedor + "\n" + "\n" + "- " + msjValida;
                }
            }
        }
        public void ProvNuevo(Proveedor proveedor, out string msjValida)
        {
            msjValida = "";
            if (String.IsNullOrEmpty(proveedor._nombreProveedor))
            {
                msjValida = "El campo Nombre Proveedor viene vacio" + "\n";
            }
                  
            if (proveedor._telefonoContacto==0)
            {
                msjValida += "El campo Telefono Contacto viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(proveedor._correoContacto))
            {
                msjValida = "El campo Correo Contacto viene vacio" + "\n";
            }
            
            if (proveedor._estado == false)
            {
                msjValida += "Debe activar el Proveedor para registrarlo" + "\n";
            }

            if (msjValida.Equals(""))
            {
               DAOProveedor cpprov = new DAOProveedor();

                bool exito = cpprov.insertaPROVEnBD(proveedor, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de Ingreso del Proveedor nombre = " + proveedor._nombreProveedor + "\n" + "\n" + "- " + msjValida;
                }
            }

        }
    }
}
