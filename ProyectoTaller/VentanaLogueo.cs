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
    public partial class VentanaLogueo : Form
    {
        public VentanaLogueo()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario._rut = txt_usuario.Text;
            usuario._contraseña = txt_contraseña.Text;
            string error;
            NEGUsuario negocioUsuario = new NEGUsuario();
            usuario = negocioUsuario.loginUsuario(usuario, out error);
            if (error.Equals(""))
            {
                MessageBox.Show("Usuario autenticado!","Ingreso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (usuario._cargo)
                {
                    case 1:
                        VentanaAdministrador frmVentanaAdministrador = new VentanaAdministrador(usuario);
                        frmVentanaAdministrador.Show();
                        this.Hide();
                        break;
                    case 2:
                        VentanaVentas frmVentanaADMVentas = new VentanaVentas(usuario);
                        frmVentanaADMVentas.Show();
                        this.Hide();
                        break;
                    case 3:
                        VentanaOPCProductos frmVentanaADMbodega = new VentanaOPCProductos(usuario);
                        frmVentanaADMbodega.Show();
                        this.Hide();
                        break;
                    case 4:
                        VentanaVentas frmVentanaVentas = new VentanaVentas(usuario);
                        frmVentanaVentas.Show();
                        this.Hide();
                        break;
                    case 5:
                        VentanaOPCProductos frmVentanabodega = new VentanaOPCProductos(usuario);
                        frmVentanabodega.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show(error,"Error en el proceso de ingreso ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            

        }

        private void llbl_olvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperacionContraseña frmpass = new RecuperacionContraseña();
            frmpass.Show();
            this.Hide();
        }
    }
}
