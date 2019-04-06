using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using Prism.Navigation;

namespace App1.ViewModels
{
    public class MainPagesViewModels: ViewModelBase
    {
        public MainPagesViewModels(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
