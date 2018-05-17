using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;


namespace CapaNegocio
{
    public class NegOperacion
    {
        public void NuevaOperacion(Operaciones operacion, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(string.Concat(operacion._id_usuario)))
            {
                msjValida += "El campo Usuario viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(string.Concat(operacion._id_tipo_operacion)))
            {
                msjValida += "El campo tipo operacion viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOOperacion cpop = new DAOOperacion();

                bool exito = cpop.insertaOperacionEnBD(operacion, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de Ingreso de operacion numero = " + operacion._Id_numero_operacion + "\n" + "\n" + "- " + msjValida;
                }
            }
        }
        public List<Operaciones> listarOperaciones(out string error)
        {
            error = "";
            try
            {
                DAOOperacion accOp = new DAOOperacion();
                return accOp.listarOperaciones(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }

        public Operaciones datOp(Operaciones op, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(string.Concat(op._id_usuario)))
                {
                    error += "El campo Usuario viene vacio" + "\n";
                }
                if (String.IsNullOrEmpty(string.Concat(op._id_tipo_operacion)))
                {
                    error += "El campo tipo operacion viene vacio" + "\n";
                }

                if (error.Equals(""))
                {
                    DAOOperacion operacion = new DAOOperacion();
                    Operaciones op2= operacion.datosOperacion(op, out error);

                    if (op2 == null)
                    {
                        error += "No hay datos de Operacion";
                    }

                    return op2;
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
        public int UltOper(out string error)
        {
            try
            {
                error = "";
                if (error.Equals(""))
                {
                    DAOOperacion opDao = new DAOOperacion();
                    int op2 = opDao.ultimaOperacion(out error);

                    if (op2 < 0)
                    {
                        error += "No hay datos de ventas";
                    }
                    return op2;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return 0;
            }
        }
    }
}
