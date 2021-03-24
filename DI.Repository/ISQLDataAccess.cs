using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DI.Repository
{
    public interface ISQLDataAccess
    {
        Task<List<T>> LoadDataAsync<T,U>(string sqlScript,U parameter);
        Task<int> ExecuteDataAsync<T>(string sqlScript, T paramters);


    }
}
