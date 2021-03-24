using DI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DI.Repository
{
    public interface IGRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task<bool> AddedAsync(T entityToAdd);
        Task<bool> UpdateAsync(int Id, T entityToUpdate);
        Task<bool> RemoveAsync(int Id);
    }
}
