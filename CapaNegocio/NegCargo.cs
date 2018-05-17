using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;


namespace CapaNegocio
{
    public class NegCargo
    {
        public string cargo(int cargo2, out string error)
        {
            try
            {
                error = "";

                if (error.Equals(""))
                {
                    DAOCargo cargodao = new DAOCargo();
                    Cargo NomCargo = new Cargo();
                    NomCargo._nombre_cargo = cargodao.nombreCargo(cargo2, out error);                 
                    return NomCargo._nombre_cargo; 
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
        public List<Cargo> listarLosCargos(out string error)
        {
            error = "";
            try
            {
                DAOCargo accCargo = new DAOCargo();
                return accCargo.listarTodosCargos(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
        public Cargo datosCargo(Cargo cargo, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(cargo._nombre_cargo))
                {
                    error += "Debe ingresar un cargo valido";
                }

                if (error.Equals(""))
                {
                    DAOCargo cargodao= new DAOCargo();
                    Cargo cargo2 = cargodao.datosCargo(cargo, out error);

                    if (cargo2 == null)
                    {
                        error += "No hay datos del cargo";
                    }

                    return cargo2;
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
        public void actualizaCargo(Cargo cargo, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(cargo._nombre_cargo))
            {
                msjValida = "El campo nombre cargo viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(string.Concat(cargo._permisos)))
            {
                msjValida += "El campo Permisos viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
               DAOCargo cpcargo = new DAOCargo();

                bool exito = cpcargo.actualizaCargo(cargo, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de actualización del cargo nombre " + cargo._nombre_cargo+ "\n" + "\n" + "- " + msjValida;
                }
            }
        }
        public void CargoNuevo(Cargo cargo, out string msjValida)
        {
            msjValida = "";
        
            if (String.IsNullOrEmpty(cargo._nombre_cargo))
            {
                msjValida = "El campo Nombre Cargo viene vacio" + "\n";
            }
      
            if (cargo._estado == false)
            {
                msjValida += "Debe activar el cargo para registrarlo" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOCargo cpcargo = new DAOCargo();

                bool exito = cpcargo.insertaCargoEnBD(cargo, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de Ingreso del cargo nombre = " + cargo._nombre_cargo + "\n" + "\n" + "- " + msjValida;
                }
            }
        }
    }

   
}
