using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using HomeFinance.Model;
using HomeFinance.Views;
using HomeFinance.Model.DataUser;

namespace HomeFinance.ViewModels
{
    public class PrijemPageViewModel : Abstract.AbstractViewModel
    {
        private DatabaseConnection db;
        public Command SavePrijem { get; set; }
        public Command CancelPrijem { get; set; }
        public PrijemPageViewModel()
        {
            SavePrijem = new Command(SavePrijem_execute);
            CancelPrijem = new Command(CancelPrijem_execute);
            db = new DatabaseConnection();
        }
        public string Nazev { get; set; }
        public string Datum { get; set; }
        public string Druh { get; set; }
        public string Castka { get; set; }

        private async void CancelPrijem_execute(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
        }
        private async void SavePrijem_execute(object obj)
        {
            db.AddPrijem(new Prijem
            {
                Id = Data.UserData.LoggedUser.Id,
                Nazev = Nazev,
                Datum = Datum,
                Druh = Druh,
                Castka = Castka
            });
            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
        }
    }
}
