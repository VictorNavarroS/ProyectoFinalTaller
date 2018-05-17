using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Permisos
    {
        private int id;
        private string nombre_permiso;

        public Permisos()
        {
        }
        public Permisos(int id, string nombre_permiso)
        {
            this.id = id;
            this.nombre_permiso = nombre_permiso;
        

        }
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _nombre_permiso
        {
            get { return nombre_permiso; }
            set { nombre_permiso = value; }
        }
    }
}
