using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;


namespace CapaNegocio
{
    public class NegPermisos
    {
        public string permisos(int permisos, out string error)
        {
            error = "";
            string nombre_permisos;
            switch (permisos)
            {
                case 1:
                    nombre_permisos = "Administrador";
                    return nombre_permisos;
                case 2:
                    nombre_permisos = "Usuario";
                    return nombre_permisos;      
                default:
                    return null;
            }

        }
        public List<Permisos> listarLosPermisos(out string error)
        {
            error = "";
            try
            {
                DAOPermisos accPermiso = new DAOPermisos();
                return accPermiso.listarTodosPermisos(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
