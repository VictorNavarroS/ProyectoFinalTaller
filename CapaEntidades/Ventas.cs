using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ventas
    {
        private int id_venta;
        private int usuario;
        private int cantidad_productos;
        private int total_venta;
        private int NroOperacion;
        public Ventas()
        {
        }
        public Ventas(int id_venta,int usuario,int cantidad_productos,int total_venta, int NroOperacion)
        {
            this.id_venta = id_venta;
            this.usuario = usuario;
            this.cantidad_productos = cantidad_productos;
            this.total_venta = total_venta;
            this.NroOperacion = NroOperacion;

        }
        public int _id_venta
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        public int _usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int _cantidad_productos
        {
            get { return cantidad_productos; }
            set { cantidad_productos = value; }
        }
        public int _total_venta
        {
            get { return total_venta; }
            set { total_venta = value; }
        }
        public int _NroOperacion
        {
            get { return NroOperacion; }
            set { NroOperacion = value; }
        }
    }
}
