using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFormsAppDesignTwo.Services
{
    public interface IDataStoreService<T>
    {
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }

    public interface IDataStoreExtendedService<T> : IDataStoreService<T>
    {
        Task<IEnumerable<T>> GetItemsExtendedAsync(string[] perameters = null);
    }
}
