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
    public partial class VentanaBodega : Form
    {
        Usuario usuario = new Usuario();
        List<Proveedor> listaDeproveedores = new List<Proveedor>();
        public VentanaBodega()
        {
        }

        public VentanaBodega(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            btn_agregar.Enabled = false;
            btn_modificarProd.Enabled = false;
            groupBox1.Enabled = false;

            NegProveedor negprov = new NegProveedor();
            string error;
            cmb_proveedor.Items.Clear();
            cmb_proveedor.Items.Insert(0, "Seleccione");
            cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            this.listaDeproveedores = negprov.listarLosProveedores(out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                this.listaDeproveedores = null;
                MessageBox.Show(error);
            }
            else
            {
                foreach (Proveedor prov in listaDeproveedores)
                {
                    cmb_proveedor.Items.Add(prov._nombreProveedor);
                }

            }
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_serie.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";            
            txt_stock.Text = "";
            txt_stockMin.Text = "";
            txt_ubicacion.Text = "";
            txt_Compra.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Productos nuevoProducto = new Productos();

                nuevoProducto._serie = txt_serie.Text;
                nuevoProducto._nombre = txt_nombre.Text;
                nuevoProducto._descripcion = txt_descripcion.Text;               
                nuevoProducto._stock = int.Parse(txt_stock.Text);
                nuevoProducto._stockMinimo = int.Parse(txt_stockMin.Text);
                nuevoProducto._ubicacion = txt_ubicacion.Text;
                nuevoProducto._valorCompra = int.Parse(txt_Compra.Text);
                nuevoProducto._proveedor = cmb_proveedor.SelectedIndex;

                if (chkb_activo.Checked)
                {
                    nuevoProducto._estadoProducto = true;
                }
                else
                {
                    nuevoProducto._estadoProducto = false;
                }

                NegProductos negProductoNuevo = new NegProductos();
                string msjError;
                negProductoNuevo.registrarProducto(nuevoProducto, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Producto registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario = usuario._id_usuario;
                    opNueva._id_tipo_operacion = 3;                   
                    opNueva._descripcion = "Ingreso de Producto serie: " + nuevoProducto._serie;                   
                    op.NuevaOperacion(opNueva, out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaBodega venBod = new VentanaBodega(usuario);
                    venBod.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btn_buscarSerie_Click(object sender, EventArgs e)
        {
            Productos productoBuscado = new Productos();
            productoBuscado._serie = txt_buscarSerie.Text;
            string error1;
            NegProductos negUsuario1 = new NegProductos();
            productoBuscado = negUsuario1.datosProductos(productoBuscado, out error1);
            if (error1.Equals(""))
            {
                groupBox1.Enabled = true;
                gbx_buscarSerie.Enabled = false;
                btn_modificarProd.Enabled = true;
                this.txt_serie.Text = txt_buscarSerie.Text;
                this.txt_nombre.Text = productoBuscado._nombre;
                this.txt_descripcion.Text = productoBuscado._descripcion;
                if (productoBuscado._estadoProducto == true)
                {
                    chkb_activo.Checked = true;
                }
                else
                {
                    chkb_activo.Checked = false;
                }
                this.txt_stock.Text = string.Concat(productoBuscado._stock);
                this.txt_stockMin.Text = string.Concat(productoBuscado._stockMinimo);
                this.txt_ubicacion.Text = productoBuscado._ubicacion;
                this.txt_Compra.Text = string.Concat(productoBuscado._valorCompra);
                NegProveedor negprov = new NegProveedor();
                string error;
                cmb_proveedor.Items.Clear();
                cmb_proveedor.Items.Insert(0, "Seleccione");
                cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
                this.listaDeproveedores = negprov.listarLosProveedores(out error);
                if (String.IsNullOrEmpty(error) == false)
                {
                    this.listaDeproveedores = null;
                    MessageBox.Show(error);
                }

                else
                {
                    foreach (Proveedor prov in listaDeproveedores)
                    {
                        cmb_proveedor.Items.Add(prov._nombreProveedor);
                    }
                    cmb_proveedor.SelectedIndex = productoBuscado._proveedor;
                }

            }
            else
            {
                MessageBox.Show(error1, "Sin Producto", MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (error1.Equals("No hay datos del Producto"))
                {
                    MessageBox.Show("Rellene el formulario para agregar nuevo Producto", "Agregar Productoo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = true;
                    gbx_buscarSerie.Enabled = false;
                    btn_agregar.Enabled = true;
                    this.txt_serie.Text = txt_buscarSerie.Text;
                    txt_buscarSerie.Text = "";
                    NegProveedor negprov = new NegProveedor();
                    string error;
                    cmb_proveedor.Items.Clear();
                    cmb_proveedor.Items.Insert(0, "Seleccione");
                    cmb_proveedor.SelectedIndex = 0;
                    cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.listaDeproveedores = negprov.listarLosProveedores(out error);
                    if (String.IsNullOrEmpty(error) == false)
                    {
                        this.listaDeproveedores = null;
                        MessageBox.Show(error);
                    }

                    else
                    {
                        foreach (Proveedor prov in listaDeproveedores)
                        {
                            cmb_proveedor.Items.Add(prov._nombreProveedor);
                        }
                    }
                }
            }
        }

        private void btn_modificarProd_Click(object sender, EventArgs e)
        {
            try
            {
                Productos actualizaProducto = new Productos();

                actualizaProducto._serie = txt_serie.Text;
                actualizaProducto._nombre = txt_nombre.Text;
                actualizaProducto._descripcion = txt_descripcion.Text;
                
                actualizaProducto._stock = int.Parse(txt_stock.Text);
                actualizaProducto._stockMinimo = int.Parse(txt_stockMin.Text);
                actualizaProducto._ubicacion = txt_ubicacion.Text;
                actualizaProducto._valorCompra = int.Parse(txt_Compra.Text);
                actualizaProducto._proveedor = cmb_proveedor.SelectedIndex;


                NegProductos negProductoNuevo = new NegProductos();
                string msjError;
                negProductoNuevo.validarProducto(actualizaProducto, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Producto fue modificado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario = usuario._id_usuario;
                    opNueva._id_tipo_operacion = 4;
                    opNueva._descripcion = "Modificacion de Producto serie: " + actualizaProducto._serie;
                    op.NuevaOperacion(opNueva, out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaBodega venBod = new VentanaBodega(usuario);
                    venBod.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            VentanaOPCProductos frmVentanaBodega = new VentanaOPCProductos(usuario);
            frmVentanaBodega.Show();
            this.Hide();

        }
    }
}
