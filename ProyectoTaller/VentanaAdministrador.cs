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
    public partial class VentanaAdministrador : Form
    {
        Usuario usuario = new Usuario();
        public VentanaAdministrador()
        {
           
        }
        public VentanaAdministrador(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.tsl_online.Text = "OnLine";
            this.tsl_online.ForeColor = Color.Green;
            this.lbl_NombreUser.Text= usuario._nombre1 + " " + usuario._apellido_p;
        }

            private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_saliradm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_manteVentas_Click(object sender, EventArgs e)
        {
            VentanaVentas frmVentanaVentas = new VentanaVentas(usuario);
            frmVentanaVentas.Show();
            this.Hide();
        }

        private void btn_manteUsuarios_Click(object sender, EventArgs e)
        {
            VentanaUsuarios frmVentanaUsuarios = new VentanaUsuarios(usuario);
            frmVentanaUsuarios.Show();
            this.Hide();

        }

        private void btn_manteBodega_Click(object sender, EventArgs e)
        {
            VentanaOPCProductos frmVentanaBodega = new VentanaOPCProductos(usuario);
            frmVentanaBodega.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCargo frmcargo = new VentanaCargo(usuario);
            frmcargo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaProveedor frmprov= new VentanaProveedor(usuario);
            frmprov.Show();
            this.Hide();
        }
    }
}
