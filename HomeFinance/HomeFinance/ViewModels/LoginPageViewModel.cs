using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using HomeFinance.Model;
using HomeFinance.Managers;
using HomeFinance.Views;
using HomeFinance.Model.DataUser;

namespace HomeFinance.ViewModels
{
    public class LoginPageViewModel: Abstract.AbstractViewModel
    {
        private UserManager userManager;
        public Command Register { get; private set; }
        public Command Login { get; private set; }
        public LoginPageViewModel()
        {
            Register = new Command(Register_execute);
            Login = new Command(Login_execute);

            userManager = new UserManager(new DatabaseConnection());
        }
        public string Username { get; set; }
        public string Password { get; set; }
        private async void Login_execute(object obj)
        {
            var user = userManager.AutenticateUser(Username, Password);
            if (user == null)
            {
                await Application.Current.MainPage.DisplayAlert("CHYBA!", "Chybné jméno nebo heslo", "Rozumím");
            }
            else
            {
                Data.UserData.LoggedUser = user;
                await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
            }

        }
        private async void Register_execute(object obj)
        {
            //Asynchronní přesměrování na stránku s registrací.
            await Application.Current.MainPage.Navigation.PushModalAsync(new RegisterPage());
        }

    }
}
