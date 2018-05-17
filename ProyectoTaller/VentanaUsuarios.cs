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
    public partial class VentanaUsuarios : Form
    {
        Usuario usuario = new Usuario();
        List<Usuario> listaDeUsuarios = new List<Usuario>();
        List<Cargo> listaDeCargos = new List<Cargo>();
        Usuario usuarioBuscado = new Usuario();
        public VentanaUsuarios()
        {

        }
        public VentanaUsuarios(Usuario usuario)
        {
            InitializeComponent();
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = false;
            this.usuario = usuario;
            this.txt_contraseña.PasswordChar = '*';
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            VentanaAdministrador frmVentanaAdministrador = new VentanaAdministrador(usuario);
            frmVentanaAdministrador.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usuarioBuscado._rut = txt_buscarRut.Text;
            string error1;
            NEGUsuario negUsuario1 = new NEGUsuario();
            usuarioBuscado = negUsuario1.datosUsuario(usuarioBuscado, out error1);
            if (error1.Equals(""))
            {
                groupBox2.Enabled = true;
                btn_modificar.Enabled = true;
                txt_rut.Enabled = false;
                this.txt_rut.Text = usuarioBuscado._rut;
                this.txt_nombre1.Text = usuarioBuscado._nombre1;
                this.txt_nombre2.Text = usuarioBuscado._nombre_2;
                this.txt_ape1.Text = usuarioBuscado._apellido_p;
                this.txt_ape2.Text = usuarioBuscado._apellido_m;                
                this.txt_correo.Text = usuarioBuscado._correo; 
                this.txt_contraseña.Text = usuarioBuscado._contraseña;
                if (usuarioBuscado._estado == true)
                {
                    chkb_activo.Checked = true;
                }
                else {
                    chkb_activo.Checked = false;
                }

                NegCargo negcargo = new NegCargo();               
                string error;
                cmb_cargo.Items.Clear();
                cmb_cargo.Items.Insert(0,"Seleccione");          
                cmb_cargo.DropDownStyle = ComboBoxStyle.DropDownList;          
                this.listaDeCargos = negcargo.listarLosCargos(out error);               
                
                if (String.IsNullOrEmpty(error) == false)
                {
                    this.listaDeCargos= null;
                    MessageBox.Show(error);
                }            
                else
                {
                    foreach (Cargo cargo in listaDeCargos)
                    {                                             
                            cmb_cargo.Items.Add(cargo._nombre_cargo);                                                     
                    }
                    cmb_cargo.SelectedIndex = usuarioBuscado._cargo;
                }
            }
                else
            {
                limpiarGrupo(groupBox2);
                MessageBox.Show(error1,"Rut sin datos ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (error1.Equals("No hay datos de usuario"))
                {
                    MessageBox.Show("Rellene el formulario para agregar nuevo usuario","Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;
                    btn_agregar.Enabled = true;
                    this.txt_rut.Text = txt_buscarRut.Text;
                    txt_buscarRut.Text = "";
                    NegCargo negcargo = new NegCargo();
                    string error;
                    cmb_cargo.Items.Clear();
                    cmb_cargo.Items.Insert(0, "Seleccione");
                    cmb_cargo.SelectedIndex = 0;
                    cmb_cargo.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.listaDeCargos = negcargo.listarLosCargos(out error);
                    if (String.IsNullOrEmpty(error) == false)
                    {
                        this.listaDeCargos = null;
                        MessageBox.Show(error);
                    }
                    else
                    {
                        foreach (Cargo cargo in listaDeCargos)
                        {                          
                                cmb_cargo.Items.Add(cargo._nombre_cargo);
                        }
                    }
                }
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                {
                txt_contraseña.PasswordChar = char.Parse("\0");
                }
            else
                { 
                txt_contraseña.PasswordChar = char.Parse("*");
                }
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario2 = new Usuario();
                usuario2._rut = this.txt_rut.Text;
                usuario2._nombre1 = this.txt_nombre1.Text;
                usuario2._nombre_2 = this.txt_nombre2.Text;
                usuario2._apellido_p = this.txt_ape1.Text;
                usuario2._apellido_m = this.txt_ape2.Text;
                usuario2._correo = this.txt_correo.Text;
                usuario2._contraseña = this.txt_contraseña.Text;
                usuario2._cargo = cmb_cargo.SelectedIndex;
                if (chkb_activo.Checked)
                {
                    usuario2._estado = true;
                }
                else
                {
                    usuario2._estado = false;
                }
                NEGUsuario neguser = new NEGUsuario();
                string msjError;
                neguser.actualizaUsuario(usuario2, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Usuario actualizado correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario=usuario._id_usuario;
                    opNueva._id_tipo_operacion =6;                    
                    opNueva._descripcion="Actualizacion de Usuario rut: "+usuario2._rut;              
                    op.NuevaOperacion(opNueva,out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaUsuarios recarga = new VentanaUsuarios(usuario);
                    recarga.Show();
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario1 = new Usuario();
                usuario1._rut = this.txt_rut.Text;
                usuario1._nombre1 = this.txt_nombre1.Text;
                usuario1._nombre_2 = this.txt_nombre2.Text;
                usuario1._apellido_p = this.txt_ape1.Text;
                usuario1._apellido_m = this.txt_ape2.Text;
                usuario1._correo = this.txt_correo.Text;
                usuario1._contraseña = this.txt_contraseña.Text;
                usuario1._cargo = cmb_cargo.SelectedIndex;
                                   
                if (chkb_activo.Checked)
                {
                    usuario1._estado = true;
                }
                else
                {
                    usuario1._estado = false;
                }
                NEGUsuario neguser = new NEGUsuario();
                string msjError;
                neguser.UsuarioNuevo(usuario1, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Usuario Agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario = usuario._id_usuario;
                    opNueva._id_tipo_operacion = 5;                    
                    opNueva._descripcion = "Ingreso de Usuario rut: " + usuario1._rut;                
                    op.NuevaOperacion(opNueva, out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaUsuarios recarga = new VentanaUsuarios(usuario);
                    recarga.Show();
                    this.Hide();                  
                }
                else
                {
                    MessageBox.Show(msjError, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ingreso Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarGrupo(groupBox2);
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            VentanaUsuarios recarga = new VentanaUsuarios(usuario);
            recarga.Show();
            this.Hide();
        }
    }
}
