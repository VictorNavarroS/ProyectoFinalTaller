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
    public partial class VentanaProveedor : Form
    {
        Usuario usuario = new Usuario();
        Proveedor provBuscado = new Proveedor();

        public VentanaProveedor()
        {
            InitializeComponent();
        }
        public VentanaProveedor(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = false;
        }
        private void limpiarGrupo(GroupBox groupbox)
        {
            foreach (Control c in groupbox.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            if (usuario._cargo == 1)
            {
                VentanaAdministrador frmVentanaAdministrador = new VentanaAdministrador(usuario);
                frmVentanaAdministrador.Show();
                this.Hide();
            }
            else
            {
                VentanaOPCProductos frmopc = new VentanaOPCProductos(usuario);
                frmopc.Show();
                this.Hide();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Proveedor provNuevo = new Proveedor();
            string msjError;
            int j;
            try
            {
                if (Int32.TryParse(string.Concat(txt_telefono.Text), out j))
                {
                    provNuevo._telefonoContacto = j;
                    provNuevo._nombreProveedor = this.txt_nombre.Text;
                    provNuevo._correoContacto = this.txt_correo.Text;
                    if (chkbActivo.Checked)
                    {
                        provNuevo._estado = true;
                    }
                    else
                    {
                        provNuevo._estado = false;
                    }
                    NegProveedor negprov = new NegProveedor();

                    negprov.ProvNuevo(provNuevo, out msjError);

                    if (String.IsNullOrEmpty(msjError))
                    {
                        MessageBox.Show("Proveedor Agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Operaciones opNueva = new Operaciones();
                        NegOperacion op = new NegOperacion();
                        string error1;
                        opNueva._id_usuario = usuario._id_usuario;
                        opNueva._id_tipo_operacion = 10;                    
                        opNueva._descripcion = "Ingreso de Proveedor nombre: " + provNuevo._nombreProveedor;                      
                        op.NuevaOperacion(opNueva, out error1);
                        if (String.IsNullOrEmpty(error1))
                        {
                            MessageBox.Show("Operacion realizada correctamente", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        VentanaProveedor frmprv = new VentanaProveedor(usuario);
                        frmprv.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    msjError = "Ingrese Valores Numericos en el campo Telefono Contacto" + "\n";
                    MessageBox.Show(msjError, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }               
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
               Proveedor ProvModificado = new Proveedor();
                ProvModificado._nombreProveedor= this.txt_nombre.Text;
                ProvModificado._telefonoContacto = int.Parse(txt_telefono.Text);
                ProvModificado._correoContacto = txt_correo.Text;
                if (chkbActivo.Checked)
                {
                    ProvModificado._estado = true;
                }
                else
                {
                    ProvModificado._estado = false;
                }
                NegProveedor negProv= new NegProveedor();
                string msjError;
                negProv.actualizaProv(ProvModificado, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Proveedor actualizado correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario = usuario._id_usuario;
                    opNueva._id_tipo_operacion = 11;                   
                    opNueva._descripcion = "Actualizacion de Proveedor nombre: " + ProvModificado._nombreProveedor;                   
                    op.NuevaOperacion(opNueva, out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaProveedor frmPrev= new VentanaProveedor(usuario);
                    frmPrev.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msjError, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscarrut_Click(object sender, EventArgs e)
        {
            provBuscado._nombreProveedor = txt_buscarProv.Text;
            string error1;
            NegProveedor negprov = new NegProveedor();
            provBuscado = negprov.datosProv(provBuscado, out error1);
            if (error1.Equals(""))
            {
                groupBox2.Enabled = true;
                btn_modificar.Enabled = true;
                this.txt_nombre.Text = provBuscado._nombreProveedor;
                txt_telefono.Text = string.Concat(provBuscado._telefonoContacto);
                txt_correo.Text = provBuscado._correoContacto;
                if (provBuscado._estado == true)
                {
                    chkbActivo.Checked = true;
                }
                else
                {
                    chkbActivo.Checked = false;
                }                
            }
            else
            {
                limpiarGrupo(groupBox2);
                MessageBox.Show(error1, "Proveedor sin datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (error1.Equals("No hay datos del Proveedor"))
                {
                    MessageBox.Show("Rellene el formulario para agregar nuevo Proveedor", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;
                    btn_agregar.Enabled = true;
                    this.txt_nombre.Text = txt_buscarProv.Text;
                    txt_buscarProv.Text = "";                 
                }
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
