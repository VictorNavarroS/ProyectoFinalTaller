using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Operaciones
    {
        private int Id_numero_operacion;
        private int id_usuario;
        private int id_tipo_operacion;  
        private string descripcion;
        private DateTime fechaOperacion;

        public Operaciones()
        {
        }
        public Operaciones(int Id_numero_operacion, int id_usuario, int id_tipo_operacion
            , string descripcion,  DateTime fechaOperacion)
        {
            this.Id_numero_operacion = Id_numero_operacion;
            this.id_usuario = id_usuario;
            this.id_tipo_operacion = id_tipo_operacion;           
            this.descripcion = descripcion;
            this.fechaOperacion = fechaOperacion;
        }
        public int _Id_numero_operacion
        {
            get { return Id_numero_operacion; }
            set { Id_numero_operacion = value; }
        }
        public int _id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public int _id_tipo_operacion
        {
            get { return id_tipo_operacion; }
            set { id_tipo_operacion = value; }
        }
        public string _descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime _fechaOperacion
        {
            get { return fechaOperacion; }
            set { fechaOperacion = value; }
        }
    }
}
