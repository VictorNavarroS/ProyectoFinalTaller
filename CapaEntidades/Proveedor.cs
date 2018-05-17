using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor
    {
        private string nombreProveedor;
        private int telefonoContacto;
        private string correoContacto;
        private bool estado;
        public Proveedor()
        {
        }
        public Proveedor(string nombreProveedor, int telefonoContacto, string correoContacto,bool estado)
        {
            this.nombreProveedor = nombreProveedor;
            this.telefonoContacto = telefonoContacto;
            this.correoContacto = correoContacto;
            this.estado = estado;
        }
        public string _nombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }

        public int _telefonoContacto
        {
            get { return telefonoContacto; }
            set { telefonoContacto = value; }
        }
        public string _correoContacto
        {
            get { return correoContacto; }
            set { correoContacto = value; }
        }
        public bool _estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
