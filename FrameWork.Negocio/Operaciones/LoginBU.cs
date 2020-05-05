using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Datos;
using System.Data;
using Entidades.Framework;
using System.Configuration;
using Tools.Utileria;

namespace FrameWork.Negocio
{
    public class LoginBU
    {

        LoginDA loginDA;

        public void Login(String NombreUsuario, String Contrasenia)
        {
            try
            {
                Usuario usuario = null;
                loginDA = new LoginDA();
                DataTable dt;

                String cadenaCifrada = CadenaMD5.cadenaToMD5(Contrasenia);

                dt = loginDA.Login(NombreUsuario, cadenaCifrada);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    usuario = new Usuario();
                    usuario.UsuarioId = Convert.ToInt32(fila["usuarioid"]);
                    usuario.UserName = fila["username"].ToString();
                    usuario.ClaveAcceso = fila["claveacceso"].ToString();
                    if (!Convert.IsDBNull(fila["fechacreacion"]))usuario.FechaCreacion = Convert.ToDateTime(fila["fechacreacion"]);
                    usuario.ColaboradorId = !Convert.IsDBNull(fila["colaboradorid"]) ? Convert.ToInt32(fila["colaboradorid"]) : 0;
                    usuario.Activo = Convert.ToBoolean(fila["activo"]);
                }
                if (usuario != null)
                {
                    SesionUsuario.Usuario = usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
