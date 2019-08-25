using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using HomeFinance.Views;
using HomeFinance.Model;
using HomeFinance.Model.DataUser;

namespace HomeFinance.ViewModels
{
    public class MainPageViewModel : Abstract.AbstractViewModel
    {
        public Command NaPrijem { get; private set; }
        public Command NaVydaj { get; private set; }
        public Command NaVypis { get; private set; }
        public MainPageViewModel()
        {
            Username = Data.UserData.LoggedUser.Username;
            Email = Data.UserData.LoggedUser.Email;
            CisloUctu = Data.UserData.LoggedUser.CisloUctu;
            OnPropertyChanged("Username");
            OnPropertyChanged("Email");
            OnPropertyChanged("CisloUctu");
            NaPrijem = new Command(NaPrijem_execute);
            NaVydaj = new Command(NaVydaj_execute);
            NaVypis = new Command(NaVypis_execute);
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string CisloUctu { get; set; }
        private async void NaPrijem_execute(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PrijemPage());
        }
        private async void NaVydaj_execute(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new VydajPage());
        }
        private async void NaVypis_execute(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new VypisPage());
        }
    }
}
