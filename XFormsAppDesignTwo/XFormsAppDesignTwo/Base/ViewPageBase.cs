﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFormsAppDesignTwo.ViewModels.Base;

namespace XFormsAppDesignTwo.Base
{
    public class ViewPageBase : ContentPage
    {
        readonly ViewModelBase _viewModel;
        public ViewModelBase ViewModel
        {
            get { return _viewModel; }
        }

        public ViewPageBase()
        {
            var viewType = this.GetType();
            var viewModelName = viewType.FullName.Replace(".Views.", ".ViewModels.").Replace("Page", "ViewModel");
            var viewModelType = Type.GetType(viewModelName);
            _viewModel = (ViewModelBase)LocatorBase.Container.Resolve(viewModelType);
            BindingContext = _viewModel;
        }
    }
}
