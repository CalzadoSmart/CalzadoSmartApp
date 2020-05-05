using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Persistencia;
using System.Data.SqlClient;

namespace Framework.Datos
{
    public class LoginDA
    {

		private DataAccess _DataAccess;

        public DataTable Login(String NombreUsuario, String Contrasenia)
        {
			try
			{
				DataTable dt;
				_DataAccess = new DataAccess();
				List<SqlParameter> lParametros = new List<SqlParameter>();
				SqlParameter Parametros;

				Parametros = new SqlParameter();
				Parametros.ParameterName = "username";
				Parametros.Value = NombreUsuario;
				lParametros.Add(Parametros);

				Parametros = new SqlParameter();
				Parametros.ParameterName = "claveacceso";
				Parametros.Value = Contrasenia;
				lParametros.Add(Parametros);

				dt = _DataAccess.EjecutarConsultaSP("SP_Login", lParametros);

				return dt;

			}
			catch (Exception ex)
			{
				throw ex;
			}
        }

    }
}
