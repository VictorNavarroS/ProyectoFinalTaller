using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;



namespace CapaNegocio
{
    public class NegTipoMod
    {
        public List<TipoOperacion> listarTipOp(out string error)
        {
            error = "";
            try
            {
                DAOTipoMod acctip = new DAOTipoMod();
                return acctip.listarTodostipos(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
