using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu_ORM
{
    public class Tools
    {
        private static SqlConnection _Connection;

        public static SqlConnection Connection
        {
            get
            {
                _Connection = _Connection ?? new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
                return _Connection;
            }
        }

        public static bool ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                return rowAffected > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (command.Connection.State != ConnectionState.Closed)
                    command.Connection.Close();
            }
        }

        public static object ExecScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }

        public static void ParametreOlustur<T>(SqlCommand cmd, KomutTip kt, T entity)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo item in properties)
            {
                string name = item.Name;
                if (name.ToLower() == "id" || name.ToLower() == "ıd" && kt == KomutTip.Insert)
                {
                    continue;
                }
                else if (kt == KomutTip.Delete && (name.ToLower() != "id" || name.ToLower() != "ıd"))
                {
                    continue;
                }
                object value = item.GetValue(entity);
                cmd.Parameters.AddWithValue("@" + name, value);
            }
        }
    }
}
