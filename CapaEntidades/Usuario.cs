using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {

        // Visibilidad y acceso: protected (solo la misma clase o quienes heredan de la misma pueden acceder)
        private int id_usuario;
        private string rut;
        private string nombre_1;
        private string nombre_2;
        private string apellido_p;
        private string apellido_m;
        private string correo;
        private string contraseña;
        private int cargo;
        private bool estado;

        // metodos constructores: permiten instanciar la clase

        public Usuario()
        {

        }

        public Usuario(int id_usuario, string rut, string nom1, string nom2, string ape1, string ape2
            , string correo, string contraseña, int cargo, bool estado)
        {
            this.id_usuario = id_usuario;
            this.rut = rut;
            this.nombre_1 = nom1;
            this.nombre_2 = nom2;
            this.apellido_p = ape1;
            this.apellido_m = ape2;
            this.correo = correo;
            this.contraseña = contraseña;
            this.cargo = cargo;
            this.estado = estado;
        }

        public int _id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string _rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string _nombre1
        {
            get { return nombre_1; }
            set { nombre_1 = value; }
        }

        public string _nombre_2
        {
            get { return nombre_2; }
            set { nombre_2 = value; }
        }

        public string _apellido_p
        {
            get { return apellido_p; }
            set { apellido_p = value; }
        }

        public string _apellido_m
        {
            get { return apellido_m; }
            set { apellido_m = value; }
        }
        public string _correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string _contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public int _cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public bool _estado
        {
            get { return estado; }
            set { estado = value; }
        }

   
    }
}
