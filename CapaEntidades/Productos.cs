using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Productos
    {
        // Visibilidad y acceso: protected (solo la misma clase o quienes heredan de la misma pueden acceder)

        private string serie;
        private string nombre;
        private string descripcion;
        private int valorCompra;
        private int valorVenta;
        private int stock;
        private int stockMinimo;
        private string ubicacion;
        private int proveedor;
        private bool estadoProducto;

        // metodos constructores: permiten instanciar la clase

        public Productos()
        {

        }

        public Productos(string serie, string nombre, string descripcion, int valorCompra, int valorVenta
      , int stock, int stockMinimo, string ubicacion, int proveedor, bool estadoProducto)
        {
            this.serie = serie;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.valorCompra = valorCompra;
            this.valorVenta = valorVenta;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.ubicacion = ubicacion;
            this.proveedor = proveedor;
            this.estadoProducto = estadoProducto;
        }

        public string _serie
        {
            get { return serie; }
            set { serie = value; }
        }

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string _descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int _valorCompra
        {
            get { return valorCompra; }
            set { valorCompra = value; }
        }

        public int _valorVenta
        {
            get { return valorVenta; }
            set { valorVenta= value; }
        }
        public int _stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int _stockMinimo
        {
            get { return stockMinimo; }
            set { stockMinimo = value; }
        }
        public string _ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int _proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public bool _estadoProducto
        {
            get { return estadoProducto; }
            set { estadoProducto = value; }
        }


    }
}
