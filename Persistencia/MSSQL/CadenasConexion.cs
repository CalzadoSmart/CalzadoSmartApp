using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Persistencia
{
    public class CadenasConexion
    {
        private String _connectionString;

        public CadenasConexion()
        {
            _connectionString = Properties.Settings.Default.CadenaConexionBD;
            //_connectionString = Properties.Settings.Default.CadenaConexionBD_Pruebas;//PRUEBAS
        }

        public String ConnectionString
        {
            get { return this._connectionString; }
        }
    }
}
