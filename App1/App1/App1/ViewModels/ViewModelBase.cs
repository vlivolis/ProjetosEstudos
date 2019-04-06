using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using Prism.Navigation;

namespace App1.ViewModels
{
    public class ViewModelBase : BindableBase, INavigatedAware, IDestructible
    {
        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        protected INavigationService NavigationService { get; private set; }
        public void Destroy()
        {
        }
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
         }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
