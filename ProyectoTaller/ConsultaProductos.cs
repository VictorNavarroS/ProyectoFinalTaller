using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;


namespace ProyectoTaller
{
    public partial class ConsultaProductos : Form
    {
        Usuario usuario = new Usuario();
        public ConsultaProductos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
          
        }

        private void btm_todos_Click(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();

            List<Productos> listaProducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            listaProducto = neg.seleccionProducto("TODOS", out msj);

            if (String.IsNullOrEmpty(msj))
            {
                foreach (Productos producto in listaProducto)
                {
                    string estado;
                    string nivel;
                    if (producto._estadoProducto == true)
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    if (producto._stock >= producto._stockMinimo)
                    {
                        nivel = "Normal";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (producto._stock < producto._stockMinimo)
                    {
                        nivel = "Stock critico";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        nivel = "No disponible";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    dgv_ConsultaProductos.Rows.Add(producto._serie, producto._nombre, producto._descripcion, estado, producto._stock, nivel, producto._ubicacion, producto._proveedor);
                }
            }
            else
            {
                MessageBox.Show(msj);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_serieCons.Text = "";
            txt_buscarSerie2.Text = "";
            txt_nombreConsu.Text = "";
            cbx_proveedorConsu.Text = "";
            check_activo.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaOPCProductos frmVentanaVentas = new VentanaOPCProductos(usuario);
            frmVentanaVentas.Show();
        }

        private void btn_buscaseriee_Click(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();

            List<Productos> listaproducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            Productos productoBus = new Productos();
            productoBus._serie = txt_buscarSerie2.Text;
            listaproducto = neg.selecProducto("serie", productoBus, out msj);

            if (string.IsNullOrEmpty(msj))
            {

                foreach (Productos producto in listaproducto)
                {
                    string estado;
                    string nivel;
                    if (producto._estadoProducto == true)
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    if (producto._stock >= producto._stockMinimo)
                    {
                        nivel = "Normal";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (producto._stock < producto._stockMinimo)
                    {
                        nivel = "Stock critico";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        nivel = "No disponible";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    dgv_ConsultaProductos.Rows.Add(producto._serie, producto._nombre, producto._descripcion, estado, producto._stock, nivel, producto._ubicacion, producto._proveedor);
                }
            }
            else
            {
                MessageBox.Show(msj);
                MessageBox.Show("Producto buscado no posee registros");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();

            List<Productos> listaproducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            Productos provBus = new Productos();
            provBus._proveedor = int.Parse(cbx_proveedorConsu.Text);
            listaproducto = neg.selecProducto("proveedor", provBus, out msj);

            if (string.IsNullOrEmpty(msj))
            {

                foreach (Productos producto in listaproducto)
                {
                    string estado;
                    string nivel;
                    if (producto._estadoProducto == true)
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    if (producto._stock >= producto._stockMinimo)
                    {
                        nivel = "Normal";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (producto._stock < producto._stockMinimo)
                    {
                        nivel = "Stock critico";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        nivel = "No disponible";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    dgv_ConsultaProductos.Rows.Add(producto._serie, producto._nombre, producto._descripcion, estado, producto._stock, nivel, producto._ubicacion, producto._proveedor);
                }
            }
            else
            {
                MessageBox.Show(msj);
            }
        }

        private void btn_nombredg_Click(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();

            List<Productos> listaproducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            Productos nombreBus = new Productos();
            nombreBus._nombre = txt_nombreConsu.Text;
            listaproducto = neg.selecProducto("nombre", nombreBus, out msj);

            if (string.IsNullOrEmpty(msj))
            {

                foreach (Productos producto in listaproducto)
                {
                    string estado;
                    string nivel;
                    if (producto._estadoProducto == true)
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    if (producto._stock >= producto._stockMinimo)
                    {
                        nivel = "Normal";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (producto._stock < producto._stockMinimo)
                    {
                        nivel = "Stock critico";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        nivel = "No disponible";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    dgv_ConsultaProductos.Rows.Add(producto._serie, producto._nombre, producto._descripcion, estado, producto._stock, nivel, producto._ubicacion, producto._proveedor);
                }
            }
            else
            {
                MessageBox.Show(msj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();

            List<Productos> listaproducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            Productos productoBus = new Productos();
            productoBus._serie = txt_serieCons.Text;
            listaproducto = neg.selecProducto("serieLIKE", productoBus, out msj);

            if (string.IsNullOrEmpty(msj))
            {

                foreach (Productos producto in listaproducto)
                {
                    string estado;
                    string nivel;
                    if (producto._estadoProducto == true)
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    if (producto._stock >= producto._stockMinimo)
                    {
                        nivel = "Normal";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (producto._stock < producto._stockMinimo)
                    {
                        nivel = "Stock critico";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        nivel = "No disponible";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    dgv_ConsultaProductos.Rows.Add(producto._serie, producto._nombre, producto._descripcion, estado, producto._stock, nivel, producto._ubicacion, producto._proveedor);
                }
            }
            else
            {
                MessageBox.Show(msj);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dgv_ConsultaProductos.Rows.Clear();

            List<Productos> listaproducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            Productos descripcionBus = new Productos();
            descripcionBus._estadoProducto = check_activo.Checked;
            listaproducto = neg.selecProducto("estado", descripcionBus, out msj);

            if (string.IsNullOrEmpty(msj))
            {

                foreach (Productos producto in listaproducto)
                {
                    string estado;
                    string nivel;
                    if (producto._estadoProducto == true)
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    if (producto._stock >= producto._stockMinimo)
                    {
                        nivel = "Normal";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (producto._stock < producto._stockMinimo)
                    {
                        nivel = "Stock critico";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        nivel = "No disponible";
                        Nivel_Stock.DefaultCellStyle.ForeColor = Color.Gray;
                    }
                    dgv_ConsultaProductos.Rows.Add(producto._serie, producto._nombre, producto._descripcion, estado, producto._stock, nivel, producto._ubicacion, producto._proveedor);
                }
            }
            else
            {
                MessageBox.Show(msj);
            }
        }

    }
}
