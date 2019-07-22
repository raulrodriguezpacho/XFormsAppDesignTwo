using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFormsAppDesignTwo.ViewModels;

namespace XFormsAppDesignTwo.Base
{
    public class ViewPageBase : ContentPage
    {
        readonly BaseViewModel _viewModel;
        public BaseViewModel ViewModel
        {
            get { return _viewModel; }
        }

        public ViewPageBase()
        {
            var viewType = this.GetType();
            var viewModelName = viewType.FullName.Replace(".Views.", ".ViewModels.").Replace("Page", "ViewModel");
            var viewModelType = Type.GetType(viewModelName);
            _viewModel = (BaseViewModel)LocatorBase.Container.Resolve(viewModelType);
            BindingContext = _viewModel;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 20, 0, 0);                    
                    break;
                case Device.Android:
                case Device.UWP:
                case Device.macOS:
                default:
                    this.Padding = new Thickness(0);
                    break;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModel = BindingContext as BaseViewModel;
            viewModel?.OnLoading();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var viewModel = BindingContext as BaseViewModel;
            viewModel?.OnUnloading();
        }
    }
}
