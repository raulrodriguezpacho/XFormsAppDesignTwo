using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Models;
using XFormsAppDesignTwo.Config;

namespace XFormsAppDesignTwo.Services
{
    class ItemsDataStoreService : DataStoreRemote, IDataStoreService<Item>
    {
        public Task<Item> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            string jsonString = string.Empty;
            try
            {
                jsonString = await base.Client.GetStringAsync(string.Format(Settings.Current.URLQuery));
                return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Item>>(jsonString));
            }
            catch { return null; }
        }
    }
}
