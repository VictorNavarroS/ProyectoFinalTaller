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
    public partial class RecuperacionContraseña : Form
    {
        public RecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void btn_enviarDatos_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario._rut = txt_ingreseRut.Text;
            usuario._correo = txt_ingresoCorreo.Text;
            string error;
            NEGUsuario negocioUsuario = new NEGUsuario();
            usuario = negocioUsuario.olvideContraseña(usuario, out error);
            if (error.Equals(""))
            {
                MessageBox.Show("Datos enviados correctamente, se enviara informacion al correo!","Solicitud Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VentanaLogueo venlogueo = new VentanaLogueo();
                venlogueo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(error, "Error al enviar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            VentanaLogueo venlogueo = new VentanaLogueo();
            venlogueo.Show();
            this.Hide();
        }
    }
}
