using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PoolConexion
    {
        private CadenasConexion cadena = new CadenasConexion();
        private String _strConnection;
        private SqlConnection _SqlConnection;
        private SqlTransaction _SqlTransaction;

        public PoolConexion() { }

        public void CreateConnection()
        {
            _strConnection = cadena.ConnectionString;
            _SqlConnection = new SqlConnection(_strConnection);            
        }

        public SqlConnection getConnection
        {
            get { return _SqlConnection; }
        }

        public void BeginTransaction()
        {
            _SqlTransaction = _SqlConnection.BeginTransaction();
        }

        public void Commit()
        {
            _SqlTransaction.Commit();
        }

        public void RollBack()
        {
            _SqlTransaction.Rollback();
        }

    }
}
