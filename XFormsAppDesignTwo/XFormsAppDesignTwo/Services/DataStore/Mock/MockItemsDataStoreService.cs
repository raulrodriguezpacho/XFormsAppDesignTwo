using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Models;

namespace XFormsAppDesignTwo.Services
{
    class MockItemsDataStoreService : IDataStoreService<Item>
    {
        public Task<Item> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }
    }
}
