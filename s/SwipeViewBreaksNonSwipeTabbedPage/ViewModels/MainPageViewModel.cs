using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SwipeViewBreaksNonSwipeTabbedPage.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            Items.Add("woo!");
        }

        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();
    }
}
