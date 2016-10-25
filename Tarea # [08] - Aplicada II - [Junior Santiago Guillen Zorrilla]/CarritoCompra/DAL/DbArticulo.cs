using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DbArticulo
    {
        SqlConnection cone;
        SqlCommand coma;

        public DbArticulo()
        {
            cone = new SqlConnection(ConfigurationManager.ConnectionStrings["DbArticulo"].ConnectionString);
            coma = new SqlCommand();
        }
        public bool Ejecutar(String CommandSql)
        {
            bool retornar = false;

            try
            {
                cone.Open();
                coma.Connection = cone;
                coma.CommandText = CommandSql;
                coma.ExecuteNonQuery();
                retornar = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cone.Close();
            }
            return retornar;
        }
        public DataTable ObtenerDatos(String CommandSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;

            try
            {
                cone.Open();
                coma.Connection = cone;
                coma.CommandText = CommandSql;

                adapter = new SqlDataAdapter(coma);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cone.Close();
            }
            return dt;
        }
        public Object ObtenerValor(String CommandSql)
        {
            Object retornar = null;
            try
            {
                cone.Open();
                coma.Connection = cone;
                coma.CommandText = CommandSql;

                retornar = coma.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                cone.Close();
            }
            return retornar;
        }
        public DataTable ListarDataList(String CommanSql)
        {
            DataTable dt = new DataTable();
            try
            {
                cone.Open();
                coma.Connection = cone;
                coma.CommandText = CommanSql;

                SqlDataReader dr = coma.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cone.Close();
            }
            return dt;
        }
    }
}
