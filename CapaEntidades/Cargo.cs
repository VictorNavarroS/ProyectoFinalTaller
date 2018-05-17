using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cargo
    {
        private int id;
        private string nombre_cargo ;
        private int permisos;
        private bool estado;

        public Cargo()
        {
        }
        public Cargo(int id, string nombre_cargo, int permisos,bool estado)
        {
            this.id = id;
            this.nombre_cargo = nombre_cargo;
            this.permisos = permisos;
            this.estado = estado;

        }
        public int _id
        {
            get { return id; }
            set {id = value; }
        }
        public string _nombre_cargo
        {
            get { return nombre_cargo; }
            set { nombre_cargo = value; }
        }

        public int _permisos
        {
            get { return permisos; }
            set { permisos = value; }
        }
        public bool _estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
