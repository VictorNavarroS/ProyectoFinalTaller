using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        private int id_venta;
        private int id_usuario;
        private string serie_producto;
        private string nombre_producto;
        private int cantidad;
        private int valor_unitario;
        public DetalleVenta()
        {
        }
        public DetalleVenta(int id_venta, int id_usuario, string serie_producto, string nombre_producto,int cantidad, int valor_unitario)
        {
            this.id_venta = id_venta;
            this.id_usuario = id_usuario;
            this.serie_producto = serie_producto;
            this.nombre_producto = nombre_producto;
            this.cantidad = cantidad;
            this.valor_unitario = valor_unitario;
        }
        public int _id_venta
        {
            get { return id_venta; }
            set { id_venta = value; }
        }
        public int _id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string _serie_producto
        {
            get { return serie_producto; }
            set { serie_producto = value; }
        }
        public string _nombre_producto
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }

        public int _cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int _valor_unitario
        {
            get { return valor_unitario; }
            set { valor_unitario = value; }
        }
    }
}
