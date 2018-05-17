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
    public partial class VentanaCargo : Form
    {
        Usuario usuario = new Usuario();
        Cargo cargobuscado = new Cargo();
        List<Permisos> listaDePermisos = new List<Permisos>();
        public VentanaCargo()
        {
        
        }
        public VentanaCargo(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            VentanaAdministrador frmVentanaAdministrador = new VentanaAdministrador(usuario);
            frmVentanaAdministrador.Show();
            this.Hide();
        }

        private void btn_buscarCargo_Click(object sender, EventArgs e)
        {
            cargobuscado._nombre_cargo = txt_buscarCargo.Text;
            string error1;
            NegCargo negcargo = new NegCargo();
            cargobuscado = negcargo.datosCargo(cargobuscado, out error1);
            if (error1.Equals(""))
            {
                groupBox2.Enabled = true;
                btn_modificar.Enabled = true;
                this.txt_nombre.Text = cargobuscado._nombre_cargo;
            
 
                if (cargobuscado._estado == true)
                {
                    chkbActivo.Checked = true;
                }
                else
                {
                    chkbActivo.Checked = false;
                }

                NegPermisos negPermisos = new NegPermisos();
                string error;
                cmb_permisos.Items.Clear();                
                cmb_permisos.Items.Insert(0, "Seleccione");
                cmb_permisos.DropDownStyle = ComboBoxStyle.DropDownList;
                this.listaDePermisos = negPermisos.listarLosPermisos(out error);
                if (String.IsNullOrEmpty(error) == false)
                {
                    this.listaDePermisos = null;
                    MessageBox.Show(error);
                }

                else
                {
                    foreach (Permisos permisos in listaDePermisos)
                    {
                            cmb_permisos.Items.Add(permisos._nombre_permiso);
                    }
                    cmb_permisos.SelectedIndex = cargobuscado._permisos;
                }
            }
            else
            {
                limpiarGrupo(groupBox2);
                MessageBox.Show(error1, "Cargo sin datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (error1.Equals("No hay datos del cargo"))
                {
                    MessageBox.Show("Rellene el formulario para agregar nuevo cargo", "Agregar cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;
                    btn_agregar.Enabled = true;
                    this.txt_nombre.Text = txt_buscarCargo.Text;
                    txt_buscarCargo.Text = "";
                    NegPermisos negpermiso = new NegPermisos();
                    string error;
                    cmb_permisos.Items.Clear();
                    cmb_permisos.Items.Insert(0, "Seleccione");
                    cmb_permisos.SelectedIndex = 0;
                    cmb_permisos.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.listaDePermisos = negpermiso.listarLosPermisos(out error);
                    if (String.IsNullOrEmpty(error) == false)
                    {
                        this.listaDePermisos = null;
                        MessageBox.Show(error);
                    }
                    else
                    {
                        foreach (Permisos permiso in listaDePermisos)
                        {
                  
                                cmb_permisos.Items.Add(permiso._nombre_permiso);
                        }
                    }
                }
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
                Cargo cargomodificado = new Cargo();
                cargomodificado._nombre_cargo = this.txt_nombre.Text;
                cargomodificado._permisos = cargobuscado._permisos;
                if (chkbActivo.Checked)
                {
                    cargomodificado._estado = true;
                }
                else
                {
                    cargomodificado._estado = false;
                }
               NegCargo negcargo = new NegCargo();
                string msjError;
                negcargo.actualizaCargo(cargomodificado, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Cargo actualizado correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario = usuario._id_usuario;
                    opNueva._id_tipo_operacion = 9;                    
                    opNueva._descripcion = "Modificacion de cargo nombre: " + cargomodificado._nombre_cargo ;                   
                    op.NuevaOperacion(opNueva, out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaCargo frmcargo = new VentanaCargo(usuario);
                    frmcargo.Show();
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
                Cargo cargonuevo = new Cargo();
                cargonuevo._nombre_cargo = this.txt_nombre.Text;
                cargonuevo._permisos = cmb_permisos.SelectedIndex;
                if (chkbActivo.Checked)
                {
                    cargonuevo._estado = true;
                }
                else
                {
                    cargonuevo._estado = false;
                }
                NegCargo negcargo = new NegCargo();
                string msjError;
                negcargo.CargoNuevo(cargonuevo, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Cargo Agregado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Operaciones opNueva = new Operaciones();
                    NegOperacion op = new NegOperacion();
                    string error1;
                    opNueva._id_usuario = usuario._id_usuario;
                    opNueva._id_tipo_operacion = 8;                    
                    opNueva._descripcion = "Ingreso de cargo nombre: " + cargonuevo._nombre_cargo ;               
                    op.NuevaOperacion(opNueva, out error1);
                    if (String.IsNullOrEmpty(error1))
                    {
                        MessageBox.Show("Operacion realizada correctamente", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msjError, "Operacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    VentanaCargo frmcargo = new VentanaCargo(usuario);
                    frmcargo.Show();
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
    }
}
