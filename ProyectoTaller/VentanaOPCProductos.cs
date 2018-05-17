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
    public partial class VentanaOPCProductos : Form
    {
        Usuario usuario = new Usuario();
        public VentanaOPCProductos()
        {
            
        }
        public VentanaOPCProductos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.lbl_NombreUser.Text = usuario._nombre1 + " " + usuario._apellido_p;
            if (usuario._cargo == 3)
            {
                btn_prov.Visible = true;
            }                       
        }

        private void btn_saliradm_Click(object sender, EventArgs e)
        {
            if (usuario._cargo == 1)
            {
                VentanaAdministrador frmVentanaAdministrador = new VentanaAdministrador(usuario);
                frmVentanaAdministrador.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void btn_manteBodega_Click(object sender, EventArgs e)
        {
            ConsultaProductos consul = new ConsultaProductos(usuario);
            consul.Show();
            this.Hide();
        }

        private void btn_manteVentas_Click(object sender, EventArgs e)
        {
            VentanaBodega ven = new VentanaBodega(usuario);
            ven.Show();
            this.Hide();
        }

        private void btn_prov_Click(object sender, EventArgs e)
        {
            VentanaProveedor frmprov = new VentanaProveedor(usuario);
            frmprov.Show();
            this.Hide();
        }
    }
}
