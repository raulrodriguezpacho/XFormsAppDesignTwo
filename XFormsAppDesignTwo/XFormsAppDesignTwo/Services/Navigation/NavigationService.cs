﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFormsAppDesignTwo.ViewModels.Base;

namespace XFormsAppDesignTwo.Services
{
    class NavigationService : INavigationService
    {
        public Page NavigationPage => Application.Current.MainPage;

        private object _navigationData;
        public object NavigationData => _navigationData;

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            _navigationData = parameter;
            return this.NavigationPage.Navigation.PushModalAsync(GetPageFromViewModel(typeof(TViewModel)));
        }

        public Task NavigateBackAsync()
        {
            return this.NavigationPage.Navigation.PopModalAsync();
        }

        private Page GetPageFromViewModel(Type viewModelType)
        {
            var viewName = viewModelType.FullName.Replace(".ViewModels.", ".Views.").Replace("ViewModel", "Page");
            var viewType = Type.GetType(viewName);
            return (Page)Activator.CreateInstance(viewType);
        }
    }
}
