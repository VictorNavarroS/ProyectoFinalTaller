using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaPersistencia
{
    public class DAOPermisos
    {
        public List<Permisos> listarTodosPermisos(out string error)
        {
            try
            {
                error = "";
                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * from permisos";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Permisos> listaDePermisos = new List<Permisos>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                       Permisos NombrePermiso = new Permisos();
                        NombrePermiso._id = int.Parse(miTabla.Rows[i]["id_permiso"].ToString());
                        NombrePermiso._nombre_permiso = miTabla.Rows[i]["nombrePermiso"].ToString();
                       
                        listaDePermisos.Add(NombrePermiso);
                    }
                    return listaDePermisos;
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
    }
}
