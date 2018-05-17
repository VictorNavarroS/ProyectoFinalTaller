using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaPersistencia
{
    public class DAOUsuario
    {
        public Usuario loginUser(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from usuarios where rut='" + usuario._rut+ "' and contraseña = '" + usuario._contraseña + "';";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return null;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    Usuario usuarioAutenticado = new Usuario();
                    usuarioAutenticado._id_usuario = int.Parse(miTabla.Rows[0]["id_usuario"].ToString());
                    usuarioAutenticado._rut = miTabla.Rows[0]["rut"].ToString();
                    usuarioAutenticado._nombre1 = miTabla.Rows[0]["nombre1"].ToString();
                    usuarioAutenticado._nombre_2 = miTabla.Rows[0]["nombre2"].ToString();
                    usuarioAutenticado._apellido_p = miTabla.Rows[0]["apellido1"].ToString();
                    usuarioAutenticado._apellido_m = miTabla.Rows[0]["apellido2"].ToString();
                    usuarioAutenticado._correo = miTabla.Rows[0]["correo"].ToString();
                    usuarioAutenticado._contraseña = miTabla.Rows[0]["contraseña"].ToString();
                    usuarioAutenticado._cargo = int.Parse(miTabla.Rows[0]["cargo"].ToString());
                    usuarioAutenticado._estado = bool.Parse(miTabla.Rows[0]["estado"].ToString());
                    return usuarioAutenticado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario datosUser(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from usuarios where rut='" + usuario._rut + "';";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return null;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    Usuario usuarioAutenticado = new Usuario();
                    usuarioAutenticado._id_usuario= int.Parse(miTabla.Rows[0]["id_usuario"].ToString());
                    usuarioAutenticado._rut = miTabla.Rows[0]["rut"].ToString();
                    usuarioAutenticado._nombre1 = miTabla.Rows[0]["nombre1"].ToString();
                    usuarioAutenticado._nombre_2 = miTabla.Rows[0]["nombre2"].ToString();
                    usuarioAutenticado._apellido_p = miTabla.Rows[0]["apellido1"].ToString();
                    usuarioAutenticado._apellido_m = miTabla.Rows[0]["apellido2"].ToString();
                    usuarioAutenticado._correo = miTabla.Rows[0]["correo"].ToString();
                    usuarioAutenticado._contraseña = miTabla.Rows[0]["contraseña"].ToString();
                    usuarioAutenticado._cargo = int.Parse(miTabla.Rows[0]["cargo"].ToString());
                    usuarioAutenticado._estado = bool.Parse(miTabla.Rows[0]["estado"].ToString());

                    return usuarioAutenticado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Usuario> listarTodosUsuarios(out string error)
        {
            try
            {
                error = "";

                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * from usuarios";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<Usuario> listaDeUsuarios = new List<Usuario>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        Usuario Usuarios = new Usuario();

                        Usuarios._rut = miTabla.Rows[i]["rut"].ToString();
                        Usuarios._nombre1 = miTabla.Rows[i]["nombre1"].ToString();
                        Usuarios._nombre_2 = miTabla.Rows[i]["nombre2"].ToString();
                        Usuarios._apellido_p = miTabla.Rows[i]["apellido1"].ToString();
                        Usuarios._apellido_m = miTabla.Rows[i]["apellido2"].ToString();
                        Usuarios._correo = miTabla.Rows[i]["contraseña"].ToString();
                        Usuarios._contraseña = miTabla.Rows[i]["contraseña"].ToString();
                        Usuarios._cargo = int.Parse(miTabla.Rows[i]["cargo"].ToString());
                        Usuarios._estado = bool.Parse(miTabla.Rows[i]["estado"].ToString());

                        listaDeUsuarios.Add(Usuarios);
                    }
                    return listaDeUsuarios;
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }
        public bool actualizaUser(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                int intExito = 0;
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter("actualizaUsuarios", conexion.getConexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlAdaptador.SelectCommand.Parameters.Add("@rut", SqlDbType.VarChar).Value = usuario._rut;
                sqlAdaptador.SelectCommand.Parameters.Add("@nombre1", SqlDbType.VarChar).Value = usuario._nombre1;
                sqlAdaptador.SelectCommand.Parameters.Add("@nombre2", SqlDbType.VarChar).Value = usuario._nombre_2;
                sqlAdaptador.SelectCommand.Parameters.Add("@apellido1", SqlDbType.VarChar).Value = usuario._apellido_p;
                sqlAdaptador.SelectCommand.Parameters.Add("@apellido2", SqlDbType.VarChar).Value = usuario._apellido_m;
                sqlAdaptador.SelectCommand.Parameters.Add("@correo", SqlDbType.VarChar).Value = usuario._correo;
                sqlAdaptador.SelectCommand.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = usuario._contraseña; ;
                sqlAdaptador.SelectCommand.Parameters.Add("@cargo", SqlDbType.Int).Value = usuario._cargo;
                sqlAdaptador.SelectCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = usuario._estado;                
                conexion.getConexion.Open();
                intExito = sqlAdaptador.SelectCommand.ExecuteNonQuery();
                conexion.getConexion.Close();

                if (intExito > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool insertaUsuarioEnBD(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                ConexionBD conexion = new ConexionBD();

                SqlParameter[] listaParametros = new SqlParameter[9];

                SqlParameter parametro = new SqlParameter();
                parametro.SqlDbType = SqlDbType.VarChar;
                parametro.ParameterName = "@rut";
                parametro.Value = usuario._rut;

                listaParametros[0] = parametro;

                SqlParameter parametro2 = new SqlParameter();
                parametro2.SqlDbType = SqlDbType.VarChar;
                parametro2.ParameterName = "@nombre1";
                parametro2.Value = usuario._nombre1;

                listaParametros[1] = parametro2;

                SqlParameter parametro3 = new SqlParameter();
                parametro3.SqlDbType = SqlDbType.VarChar;
                parametro3.ParameterName = "@nombre2";
                parametro3.Value = usuario._nombre_2;

                listaParametros[2] = parametro3;

                SqlParameter parametro4 = new SqlParameter();
                parametro4.SqlDbType = SqlDbType.VarChar;
                parametro4.ParameterName = "@apellido1";
                parametro4.Value = usuario._apellido_p;

                listaParametros[3] = parametro4;

                SqlParameter parametro5 = new SqlParameter();
                parametro5.SqlDbType = SqlDbType.VarChar;
                parametro5.ParameterName = "@apellido2";
                parametro5.Value = usuario._apellido_m;

                listaParametros[4] = parametro5;

                SqlParameter parametro6 = new SqlParameter();
                parametro6.SqlDbType = SqlDbType.VarChar;
                parametro6.ParameterName = "@correo";
                parametro6.Value = usuario._correo;

                listaParametros[5] = parametro6;

                SqlParameter parametro7 = new SqlParameter();
                parametro7.SqlDbType = SqlDbType.VarChar;
                parametro7.ParameterName = "@contraseña";
                parametro7.Value = usuario._contraseña;

                listaParametros[6] = parametro7;

                SqlParameter parametro8 = new SqlParameter();
                parametro8.SqlDbType = SqlDbType.Int;
                parametro8.ParameterName = "@cargo";
                parametro8.Value = usuario._cargo;

                listaParametros[7] = parametro8;

                SqlParameter parametro9 = new SqlParameter();
                parametro9.SqlDbType = SqlDbType.Bit;
                parametro9.ParameterName = "@estado";
                parametro9.Value = usuario._estado;

                listaParametros[8] = parametro9;


                return conexion.ejecutaProcedimientoAlmacenadoManipulacion(listaParametros, "Nuevo_usuario", out error);
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }

        }
        public Usuario olvUser(Usuario usuario, out string error)
        {
            try
            {
                error = "";
                ConexionBD cnx = new ConexionBD();
                string query = "select * from usuarios where rut='" + usuario._rut + "' and correo = '" + usuario._correo + "';";
                DataTable miTabla = cnx.selecData(query, out error);

                if (miTabla == null)
                {
                    return null;
                }
                else if (miTabla.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    Usuario usuarioAutenticado = new Usuario();
                    usuarioAutenticado._rut = miTabla.Rows[0]["rut"].ToString();
                    usuarioAutenticado._correo = miTabla.Rows[0]["correo"].ToString();
                    return usuarioAutenticado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
