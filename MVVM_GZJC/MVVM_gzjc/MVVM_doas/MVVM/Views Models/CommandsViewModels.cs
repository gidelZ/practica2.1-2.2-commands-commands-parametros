using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_bbhdzp.MVVM.Views;

namespace MVVM_bbhdzp.MVVM.Views_Models
{
    public class CommandsViewModels
    {
        public ICommand ClickMeCommand { get; }

        public ICommand SearchCommand { get; }

        public string SearchData { get; set; }



        public CommandsViewModels()
        {
            ClickMeCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Alert", "Button Clicked!", "OK");
            });
            SearchCommand = new Command(() =>
            {
                var data = SearchData;
            });
        }

        private void alert()
        {
           
        }
    }
}
