using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu_ORM
{
    public class ORMBase<T> : IORM<T> where T : class
    {
        private string ClassName
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter($"prc_{ClassName}_Select", Tools.Connection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand($"prc_{ClassName}_Insert", Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(cmd, KomutTip.Insert, entity);
            return Tools.ExecuteNonQuery(cmd);
        }

        public object InsertScalar(T entity)
        {
            SqlCommand cmd = new SqlCommand($"prc_{ClassName}_Insert", Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(cmd, KomutTip.Insert, entity);
            return Tools.ExecScalar(cmd);
        }

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand($"prc_{ClassName}_Update", Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(cmd, KomutTip.Update, entity);
            return Tools.ExecuteNonQuery(cmd);
        }

        public bool Delete(T entity)
        {
            SqlCommand cmd = new SqlCommand($"prc_{ClassName}_Delete", Tools.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(cmd, KomutTip.Delete, entity);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
