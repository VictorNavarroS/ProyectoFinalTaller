using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistencia;

namespace CapaNegocio
{

    public class NEGUsuario
    {
        public Usuario loginUsuario(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                if (String.IsNullOrEmpty(usuario._rut))
                {
                    error += "Debe ingresar un rut de usuario" + "\n";
                }
                if (String.IsNullOrEmpty(usuario._contraseña))
                {
                    error += "Debe ingresar una contraseña" + "\n";
                }
                if (error.Equals(""))
                {
                    DAOUsuario usuarioDao = new DAOUsuario();
                    Usuario usuario1 = usuarioDao.loginUser(usuario, out error);

                    if (usuario1 == null)
                    {
                        error += "El password y el usuario no coinciden";
                    }

                    return usuario1;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public Usuario datosUsuario(Usuario usuario, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(usuario._rut))
                {
                    error += "Debe ingresar un rut ";
                }

                if (error.Equals(""))
                {
                    DAOUsuario usuarioDao = new DAOUsuario();
                    Usuario usuario2 = usuarioDao.datosUser(usuario, out error);

                    if (usuario2 == null)
                    {
                        error += "No hay datos de usuario";
                    }

                    return usuario2;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public List<Usuario> listarLosUsuarios(out string error)
        {
            error = "";
            try
            {
                DAOUsuario accUser = new DAOUsuario();
                return accUser.listarTodosUsuarios(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
        public void actualizaUsuario(Usuario usuario, out string msjValida)
        {
            msjValida = "";

            if (String.IsNullOrEmpty(usuario._rut))
            {
                msjValida = "El campo rut viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario._nombre1))
            {
                msjValida += "El campo primer nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario._apellido_p))
            {
                msjValida += "El campo apellido paterno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario._apellido_m))
            {
                msjValida += "El campo apellido materno viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(usuario._correo))
            {
                msjValida += "El campo correo viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(usuario._contraseña))
            {
                msjValida += "El campo contraseña viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(string.Concat(usuario._cargo)))
            {
                msjValida += "El campo Cargo viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOUsuario cpAlumno = new DAOUsuario();

                bool exito = cpAlumno.actualizaUser(usuario, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de actualización del Usuario rut " + usuario._rut + "\n" + "\n" + "- " + msjValida;
                }
            }
        }
        public void UsuarioNuevo(Usuario usuario, out string msjValida)
        {
            msjValida = "";
            int cargo = usuario._cargo;
            bool estado = usuario._estado;
            if (String.IsNullOrEmpty(usuario._rut))
            {
                msjValida = "El campo rut viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario._nombre1))
            {
                msjValida += "El campo primer nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario._apellido_p))
            {
                msjValida += "El campo apellido paterno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(usuario._apellido_m))
            {
                msjValida += "El campo apellido materno viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(usuario._correo))
            {
                msjValida += "El campo correo viene vacio" + "\n";
            }
            if (String.IsNullOrEmpty(usuario._contraseña))
            {
                msjValida += "El campo contraseña viene vacio" + "\n";
            }
            if (usuario._cargo == 0)
            {
                msjValida += "El campo cargo viene vacio" + "\n";
            }
            if (estado ==  false)
            {
                msjValida += "Debe activar el Usuario para registrarlo" + "\n";
            }

            if (msjValida.Equals(""))
            {
                DAOUsuario cpAlumno = new DAOUsuario();

                bool exito = cpAlumno.insertaUsuarioEnBD(usuario, out msjValida);

                if (exito == false)
                {
                    msjValida = "Error en el proceso de Ingreso del Usuario rut " + usuario._rut + "\n" + "\n" + "- " + msjValida;
                }
            }
        }
        public Usuario olvideContraseña(Usuario usuario, out string error)
        {
            try
            {
                error = "";

                if (String.IsNullOrEmpty(usuario._rut))
                {
                    error += "Debe ingresar un rut "  +"\n";
                }

                if (String.IsNullOrEmpty(usuario._correo))
                {
                    error += "Debe ingresar un correo " + "\n";
                }
                if (error.Equals(""))
                {
                    DAOUsuario usuarioDao = new DAOUsuario();
                    Usuario usuario2 = usuarioDao.olvUser(usuario, out error);

                    if (usuario2 == null)
                    {
                        error += "Favor ingresar correo valido";
                    }

                    return usuario2;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
    }
    }

