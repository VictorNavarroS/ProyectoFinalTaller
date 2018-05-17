using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;


namespace CapaNegocio
{
    public class NegProductos
    {
        public Productos datosProductos(Productos producto, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(producto._serie))
                {
                    error += "Debe ingresar una Serie ";
                }

                if (error.Equals(""))
                {
                    DAOProductos productoDao = new DAOProductos();
                    Productos producto2 = productoDao.datosProductos(producto, out error);

                    if (producto2 == null)
                    {
                        error += "No hay datos del Producto";
                    }

                    return producto2;
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


        public void registrarProducto(Productos producto, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(producto._serie))
            {
                msjValida = "El campo serie viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto._nombre))
            {
                msjValida += "El campo nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto._descripcion))
            {
                msjValida += "El campo descripcion viene vacio" + "\n";
            }

            if (producto._estadoProducto==false)
            {
                msjValida += "Debe activar el producto para registrarlo" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._stock)))
            {
                msjValida += "El campo EnStock viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._stockMinimo)))
            {
                msjValida += "El campo stock minimo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto._ubicacion))
            {
                msjValida += "El campo ubicacion viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._valorCompra)))
            {
                msjValida += "El campo valor compra viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOProductos cpAlumno = new DAOProductos();

                bool exito = cpAlumno.insertaProductoBD(producto, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de registro del producto serie " + producto._serie + "\n" + "\n" + "- " + msjValida;
                }
            }
        }

        public List<Productos> seleccionProducto(string tipoConsulta, out string msjValida)
        {
            msjValida = "";
            List<Productos> lista = new List<Productos>();

            try
            {
                if (tipoConsulta.Equals("TODOS"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    lista = ejemplo.listarTodosLosProductos( out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }       
                }
                else
                {
                    msjValida = "No has seleccionado ningún tipo de consulta";
                    return null;
                }
            }
            catch (Exception ex)
            {
                msjValida = ex.Message;
                return null;
            }
        }
        public void validarProducto(Productos producto, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(producto._serie))
            {
                msjValida = "El campo serie viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto._nombre))
            {
                msjValida += "El campo nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto._descripcion))
            {
                msjValida += "El campo descripcion viene vacio" + "\n";
            }

            if (string.IsNullOrEmpty(string.Concat(producto._estadoProducto)))
            {
                msjValida += "El campo Estado viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._stock)))
            {
                msjValida += "El campo EnStock viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._stockMinimo)))
            {
                msjValida += "El campo stock minimo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(producto._ubicacion))
            {
                msjValida += "El campo ubicacion viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._valorCompra)))
            {
                msjValida += "El campo valor compra viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(producto._proveedor)))
            {
                msjValida += "El campo proveedor viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOProductos cProducto = new DAOProductos();

                bool exito = cProducto.actualizaProducto(producto, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de registro del producto serie " + producto._serie + "\n" + "\n" + "- " + msjValida;
                }
            }
        }
        public List<Productos> selecProducto(string tipoConsulta, Productos producto1, out string msjValida)
        {
            msjValida = "";
            List<Productos> lista = new List<Productos>();

            try
            {
                if (tipoConsulta.Equals("TODOS"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    lista = ejemplo.listarTodosLosProductos(out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }

                }
                else if (tipoConsulta.Equals("serie"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    string consultas = " where serie ='" + producto1._serie + "';";
                    lista = ejemplo.listarLosProductos(consultas, out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }
                }

                else if (tipoConsulta.Equals("serieLIKE"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    string consultas = " where serie like '%" + producto1._serie + "%';";
                    lista = ejemplo.listarLosProductos(consultas, out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }
                }


                else if (tipoConsulta.Equals("nombre"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    string consultas = " where nombre like '%" + producto1._nombre + "%';";
                    lista = ejemplo.listarLosProductos(consultas, out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }
                }





                else if (tipoConsulta.Equals("proveedor"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    string consultas = " where proveedor ='" + producto1._proveedor + "';";
                    lista = ejemplo.listarLosProductos(consultas, out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }
                }


                else if (tipoConsulta.Equals("estado"))
                {
                    DAOProductos ejemplo = new DAOProductos();
                    string consultas = " where estado ='" + producto1._estadoProducto + "';";
                    lista = ejemplo.listarLosProductos(consultas, out msjValida);

                    if (lista == null)
                    {
                        msjValida = "La consulta no devolvio datos";
                        return null;
                    }
                    else
                    {
                        return lista;
                    }
                }


                else
                {
                    msjValida = "No has seleccionado ningún tipo de consulta";
                    return null;
                }
            }
            catch (Exception ex)
            {
                msjValida = ex.Message;
                return null;
            }
        }



    }
}
