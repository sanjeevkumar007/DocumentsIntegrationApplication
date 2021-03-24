using DI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DI.Repository
{
    public class Repository<T> : IGRepository<T> where T : BaseEntity
    {
        
        public Task<bool> AddedAsync(T entityToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int Id, T entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
