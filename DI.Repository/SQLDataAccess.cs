using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Repository
{
    public class SQLDataAccess : ISQLDataAccess
    {
        string connectionString = string.Empty;
        public SQLDataAccess(IConfiguration configuration)
        {
            connectionString=configuration.GetConnectionString("");   
        }
        public async Task<List<T>> LoadDataAsync<T, U>(string sqlScript, U parameter)
        {
            using (IDbConnection connection=new SqlConnection(connectionString))
            {
                if (connection.State!=ConnectionState.Open)
                {
                    connection.Open();
                }
                var rows = await connection.QueryAsync<T>(sqlScript, parameter, commandType: CommandType.StoredProcedure);
                return rows.ToList();
            }
        }

        public async Task<int> ExecuteDataAsync<T>(string sqlScript, T paramters)
        {
            int result = 0;
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                result  = await connection.ExecuteAsync(sqlScript, paramters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

    }
}
