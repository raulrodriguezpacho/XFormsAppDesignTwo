using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.DTOs;
using XFormsAppDesignTwo.Extensions;
using XFormsAppDesignTwo.Models;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.ViewModels
{
    class OtherViewModel : BaseViewModel
    {
        private readonly IDataStoreService<Item> _dataStoreService;

        public OtherViewModel(IDataStoreService<Item> dataStoreService)
        {
            dataStoreService = _dataStoreService;
            GetData();
        }

        private async void GetData()
        {
            await GetItems(false);
        }

        private async Task GetItems(bool refresh)
        {
            IsBusy = true;
            try
            {
                var items = await _dataStoreService.GetItemsAsync();
                if (!items.IsNullOrEmpty())
                {
                    
                }
                else
                {
                    
                }
            }
            catch { }
            finally { IsBusy = false; }            
        }
    }
}
