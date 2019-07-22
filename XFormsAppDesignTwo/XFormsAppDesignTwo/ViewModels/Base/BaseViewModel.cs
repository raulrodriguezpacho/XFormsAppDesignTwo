using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XFormsAppDesignTwo.Base;
using XFormsAppDesignTwo.Services;

namespace XFormsAppDesignTwo.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected readonly INavigationService NavigationService;

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy == value)
                    return;

                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void OnLoading() { }

        public virtual void OnUnloading() { }

        public BaseViewModel()
        {
            NavigationService = LocatorBase.Resolve<INavigationService>();
        }

        public void ShowAlert(string title, string message, string cancel)
        {
            App.Current.MainPage.DisplayAlert(title ?? string.Empty, message, cancel);
        }

        public async Task<bool> ShowToDo(string title, string message, string accept, string cancel)
        {
            return await App.Current.MainPage.DisplayAlert(title ?? string.Empty, message, accept, cancel);
        }
    }
}
