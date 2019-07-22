using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFormsAppDesignTwo.Services
{
    public class RepositoryService<T> : IRepositoryService<T> where T : new()
    {
        public Task<int> ClearAsync(string tableName)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasDataAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAllAsync(List<T> enities)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
