using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TipoOperacion
    {
        private int Id_tipo;
        private string tipo_operacion;

        public TipoOperacion()
        {
        }
        public TipoOperacion(int Id_tipo, string tipo_operacion)
        {
            this.Id_tipo = Id_tipo;
            this.tipo_operacion = tipo_operacion;

        }
        public string _tipo_operacion
        {
            get { return tipo_operacion; }
            set { tipo_operacion = value; }
        }              

        public int _id
        {
            get { return Id_tipo; }
            set { Id_tipo = value; }
        }
    }
}
