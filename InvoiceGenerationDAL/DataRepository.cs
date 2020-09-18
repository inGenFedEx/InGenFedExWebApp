using Dapper;
using InvoiceGenerationBO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace InvoiceGenerationDAL
{
    public interface IDataRepository
    {
        List<UserEntity> GetUserEntityItems();
        object InsertEntityItem(Entity entity);
        object InsertP2Source(P2Source entity);

        object Insert<T>(T entity, string Procedurename);

        object BulkInsert<T>(List<T> entity, string Procedurename);

        List<T> Get<T>(string Procedurename);
    }
    public class DataRepository : IDataRepository
    {
        public readonly string _connectionstring = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ToString();

        public List<UserEntity> GetUserEntityItems()
        {
            List<UserEntity> lstUserEntity = null;
            string sql = "usp_GetUserEntityItems";
            using (var conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                lstUserEntity = conn.Query<UserEntity>(sql, commandType: CommandType.StoredProcedure).ToList();
            }
            return lstUserEntity;
        }

        public object InsertEntityItem(Entity entity)
        {
            object obj = null;
            using (var conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                obj = conn.Execute("usp_InsertEntityItem", entity, commandType: CommandType.StoredProcedure);
            }
            return obj;
        }

        public object InsertP2Source(P2Source entity)
        {
            object obj = null;
            using (var conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                obj = conn.Execute("usp_InsertP2Source", entity, commandType: CommandType.StoredProcedure);
            }
            return obj;
        }

        public object Insert<T>(T entity,string Procedurename)
        {
            object obj = null;
            using (var conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                obj = conn.Execute(Procedurename, entity, commandType: CommandType.StoredProcedure);
            }
            return obj;
        }

        public object BulkInsert<T>(List<T> entity, string Procedurename)
        {
            object obj = null;
            using (var conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                obj = conn.Execute(Procedurename, entity, commandType: CommandType.StoredProcedure);
            }
            return obj;
        }

        public List<T> Get<T>(string Procedurename)
        {
            List<T> ts = null;
            using (var conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                ts = conn.Query<T>(Procedurename,commandType: CommandType.StoredProcedure).ToList();
            }
            return ts;
        }
    }
}
