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
    public class DAOTipoMod
    {
        public List<TipoOperacion> listarTodostipos(out string error)
        {
            try
            {
                error = "";
                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * from tipo_operacion";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<TipoOperacion> listaDeTipos = new List<TipoOperacion>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        TipoOperacion tipo = new TipoOperacion();
                        tipo._id = int.Parse(miTabla.Rows[i]["Id_tipo"].ToString());
                        tipo._tipo_operacion = miTabla.Rows[i]["tipo_operacion"].ToString();                        
                        listaDeTipos.Add(tipo);
                    }
                    return listaDeTipos;
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
