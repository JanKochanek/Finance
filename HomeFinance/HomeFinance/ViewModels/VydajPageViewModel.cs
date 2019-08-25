using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using HomeFinance.Model;
using HomeFinance.Views;
using HomeFinance.Model.DataUser;

namespace HomeFinance.ViewModels
{
    class VydajPageViewModel : Abstract.AbstractViewModel
    {
        private DatabaseConnection db;
        public Command SaveVydaj { get; set; }
        public Command CancelVydaj { get; set; }
        public VydajPageViewModel()
        {
            SaveVydaj = new Command(SaveVydaj_execute);
            CancelVydaj = new Command(CancelVydaj_execute);
            db = new DatabaseConnection();
        }
        public string Nazev { get; set; }
        public string Datum { get; set; }
        public string Druh { get; set; }
        public string Castka { get; set; }

        private async void CancelVydaj_execute(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
        }
        private async void SaveVydaj_execute(object obj)
        {
            db.AddVydaj(new Vydaj
            {
                Id = Data.UserData.LoggedUser.Id,
                Nazev = Nazev,
                Castka = Castka
            });
            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
        }
    }
}
