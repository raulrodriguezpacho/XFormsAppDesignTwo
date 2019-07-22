using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFormsAppDesignTwo.Services
{
    public interface IRepositoryService<T>
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(int id);
        Task<int> InsertAsync(T entity);
        Task<int> InsertAllAsync(List<T> enities);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<int> ClearAsync(string tableName);
        Task<bool> HasDataAsync();
    }
}
