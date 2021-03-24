using DI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Repository
{
    public class Repository<T> : IGRepository<T> where T : BaseEntity
    {

        private readonly ISQLDataAccess _sqlDataAccess;

        public Repository(ISQLDataAccess sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }

        public async Task<bool> AddedAsync(T entityToAdd)
        {
            var result=await _sqlDataAccess.ExecuteDataAsync("sp_Insert",entityToAdd);
            if (result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            var parameter = new { };
            return await _sqlDataAccess.LoadDataAsync<T, dynamic>("sp_GetAll", parameter);
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            var parameter = new { Id=Id};

            var row=await _sqlDataAccess.LoadDataAsync<T, dynamic>("sp_GetById", parameter);

            return row.FirstOrDefault<T>();
        }

        public async Task<bool> RemoveAsync(int Id)
        {
            var parameter = new { Id = Id };
            var result = await _sqlDataAccess.ExecuteDataAsync("sp_Remove", parameter);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(int Id, T entityToUpdate)
        {
            var parameters = new { Id = Id, param = entityToUpdate };
            var result = await _sqlDataAccess.ExecuteDataAsync("sp_Update", parameters);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
