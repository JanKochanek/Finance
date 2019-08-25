using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using HomeFinance.Model;
using HomeFinance.Views;

namespace HomeFinance.ViewModels
{
    public class RegisterPageViewModel : Abstract.AbstractViewModel
    {
        private DatabaseConnection db;
        public Command Register { get; set; }
        public RegisterPageViewModel()
        {
            Register = new Command(Register_execute);
            db = new DatabaseConnection();
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CisloUctu { get; set; }

        private async void Register_execute(object obj)
        {
            db.RegisterUserToDB(new User
            {
                Username = Username,
                Password = Password,
                Email = Email,
                CisloUctu = CisloUctu
            });
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
        }
    }
}
