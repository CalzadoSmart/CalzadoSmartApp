using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public class DataAccess
    {
        private SqlConnection _connection;
        private PoolConexion _poolConexion;

        public DataAccess()
        {
            _poolConexion = new PoolConexion();
        }


        public DataTable EjecutarConsultaSP(String NombreSP, List<SqlParameter> Parametros)
        {
            try
            {
                DataTable dtSeleccion = new DataTable();
                _poolConexion.CreateConnection();
                _connection = _poolConexion.getConnection;

                SqlCommand ComandoSql = new SqlCommand(NombreSP, _connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600000
                };

                if (Parametros != null)
                {
                    foreach (SqlParameter SqlParam in Parametros)
                    {
                        ComandoSql.Parameters.Add(SqlParam);
                    }
                }

                _connection.Open();
                SqlDataAdapter SqlAdapter = new SqlDataAdapter();
                SqlAdapter.SelectCommand = ComandoSql;
                SqlAdapter.Fill(dtSeleccion);
                dtSeleccion.TableName = NombreSP;

                _connection.Close();

                return dtSeleccion;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable EjecutarConsultaSP(String NombreSP)
        {
            try
            {
                DataTable dtSeleccion = new DataTable();
                _poolConexion.CreateConnection();
                _connection = _poolConexion.getConnection;

                SqlCommand ComandoSql = new SqlCommand(NombreSP, _connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600000
                };

                _connection.Open();
                SqlDataAdapter SqlAdapter = new SqlDataAdapter();
                SqlAdapter.SelectCommand = ComandoSql;
                SqlAdapter.Fill(dtSeleccion);
                dtSeleccion.TableName = NombreSP;

                _connection.Close();

                return dtSeleccion;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EjecutarSetenciaSP(String NombreSP, List<SqlParameter> Parametros)
        {
            try
            {
                int Resultado = 0;
                _poolConexion.CreateConnection();
                _connection = _poolConexion.getConnection;

                SqlCommand ComandoSql = new SqlCommand(NombreSP, _connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600000
                };

                if (Parametros != null)
                {
                    foreach (SqlParameter SqlParam in Parametros)
                    {
                        ComandoSql.Parameters.Add(SqlParam);
                    }
                }

                _connection.Open();
                Resultado = ComandoSql.ExecuteNonQuery();
                _connection.Close();

                return Resultado;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EjecutarSetenciaSP(String NombreSP)
        {
            try
            {
                int Resultado = 0;
                _poolConexion.CreateConnection();
                _connection = _poolConexion.getConnection;

                SqlCommand ComandoSql = new SqlCommand(NombreSP, _connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600000
                };


                _connection.Open();
                Resultado = ComandoSql.ExecuteNonQuery();
                _connection.Close();

                return Resultado;
            }
            catch (SqlException sqlex)
            {
                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
