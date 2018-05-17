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
    public partial class VentanaVentas : Form
    {
        Usuario usuario = new Usuario();
        NegVentas venta = new NegVentas();
        NegOperacion oper = new NegOperacion();   
        int numOp;
        int ultima;

        public object DbNull { get; private set; }

        public VentanaVentas()
        {

        }
        public VentanaVentas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            btn_agregar.Enabled = false;
            groupBox3.Enabled = false;
            if (usuario._cargo != 4)
            {
                menuStrip1.Visible = true;
            }
        }


        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentas frmReporteVentas = new ReporteVentas(usuario);
            frmReporteVentas.Show();
            this.Hide();
        }

        private void btm_todos_Click(object sender, EventArgs e)
        {
            dgv_listaProductos.Rows.Clear();

            List<Productos> listaProducto = new List<Productos>();
            NegProductos neg = new NegProductos();
            string msj;
            listaProducto = neg.seleccionProducto("TODOS", out msj);

            if (String.IsNullOrEmpty(msj))
            {
                foreach (Productos producto in listaProducto)
                {
                    dgv_listaProductos.Rows.Add(producto._serie, producto._nombre);
                }
            }
            else
            {
                MessageBox.Show(msj);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Productos productoBuscado = new Productos();
            productoBuscado._serie = txt_serie.Text;
            string error1;
            NegProductos negUsuario1 = new NegProductos();
            productoBuscado = negUsuario1.datosProductos(productoBuscado, out error1);
            if (error1.Equals(""))
            {
                this.txt_nombre.Text = productoBuscado._nombre;
                this.txt_descripcion.Text = productoBuscado._descripcion;
                this.txt_stock.Text = string.Concat(productoBuscado._stock);
                this.txt_valorVenta.Text = string.Concat(productoBuscado._valorVenta);
                lbl_disponible.ForeColor = Color.Blue;
            }
            else
            {
                MessageBox.Show(error1,"Producto No encontrado",MessageBoxButtons.OK,MessageBoxIcon.Warning);         
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dgv_listaProductos.Rows.Clear();
        }
        private void btn_nuevaVenta_Click(object sender, EventArgs e)
        {
            Ventas ventabuscada = new Ventas();
            string error;
            ventabuscada = venta.UltVenta(out error);            
            if (error.Equals(""))
            {
                ultima = ventabuscada._id_venta;
                this.lbl_numVenta.Text = string.Concat(ultima);
                btn_agregar.Enabled = true;
                groupBox3.Enabled = true;
            }           
            else
            {
                MessageBox.Show(error, "No hay datos de venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_ventas.Rows.Clear();

            txt_totalVenta.Text = "";
        }
        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            if (usuario._cargo==1)
                {
                    VentanaAdministrador frmVentanaadmin= new VentanaAdministrador(usuario);
                    frmVentanaadmin.Show();
                Hide();
                }
            else
                { 
                    Application.Exit();
                }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_stock.Text) > int.Parse(txt_vender.Text))
            {
                dgv_ventas.Rows.Add(txt_serie.Text, txt_nombre.Text, txt_vender.Text, txt_valorVenta.Text);

                txt_serie.Text = "";
                txt_nombre.Text = "";
                txt_descripcion.Text = "";
                txt_stock.Text = "";
                txt_valorVenta.Text = "";
                txt_vender.Text = "";

                double total = 0;
                double totalcant = 0;
                foreach (DataGridViewRow row in dgv_ventas.Rows)
                {
                    totalcant = (Convert.ToDouble(row.Cells["Column9"].Value))* Convert.ToDouble(row.Cells["Column10"].Value); 
                    total += totalcant;
                }
                txt_totalVenta.Text = Convert.ToString(total);

            }
            else
            {
                MessageBox.Show("Cantidad de venta supera el saldo en bodega, favor revisar");
            }
        }

        private void btn_finalizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string msjError;
                string msjer;
                Operaciones operacionNueva = new Operaciones();   
                operacionNueva._id_usuario= usuario._id_usuario;
                operacionNueva._id_tipo_operacion = 1;                
                operacionNueva._descripcion = string.Concat("Venta Nro "+ lbl_numVenta.Text);                        
                NegOperacion newOp = new NegOperacion();
                newOp.NuevaOperacion(operacionNueva, out msjer);

                if (String.IsNullOrEmpty(msjer))
                {
                    MessageBox.Show("Operacion realizada correctamente", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ventas ventaNueva = new Ventas();
                    numOp = oper.UltOper(out msjError);
                    ventaNueva._usuario = usuario._id_usuario;
                    ventaNueva._cantidad_productos = dgv_ventas.Rows.Count;
                    ventaNueva._total_venta = int.Parse(txt_totalVenta.Text);
                    ventaNueva._NroOperacion = numOp;

                    NegVentas neguVenta = new NegVentas();
                    neguVenta.VentaNuevo(ventaNueva, out msjError);

                    if (String.IsNullOrEmpty(msjError))
                    {
                        MessageBox.Show("Venta Registrada", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        NegDetalleVenta det = new NegDetalleVenta();
                        DetalleVenta detalle = new DetalleVenta();
                        string er="";
                        foreach (DataGridViewRow dato in dgv_ventas.Rows)
                        {
                            detalle._id_usuario = usuario._id_usuario;
                            detalle._id_venta = int.Parse(lbl_numVenta.Text);
                            detalle._serie_producto=Convert.ToString(dato.Cells["Column6"].Value);
                            detalle._nombre_producto = Convert.ToString(dato.Cells["Column7"].Value);
                            detalle._cantidad = Convert.ToInt32(dato.Cells["Column9"].Value);
                            detalle._valor_unitario = Convert.ToInt32(dato.Cells["Column10"].Value);
                            det.NuevoDetalle(detalle,out er);
                        }
                        if (String.IsNullOrEmpty(er))
                        {
                            MessageBox.Show("Detalle Venta Registrada", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VentanaVentas recarga = new VentanaVentas(usuario);
                            recarga.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show(msjError, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(msjer, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
