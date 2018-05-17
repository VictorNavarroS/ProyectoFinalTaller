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
    public partial class ReporteVentas : Form
    {
        Usuario usuario = new Usuario();
        public ReporteVentas()
        {
           
        }
        public ReporteVentas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaVentas frmVentanaVentas = new VentanaVentas(usuario);
            frmVentanaVentas.Show();
        }
    }
}
