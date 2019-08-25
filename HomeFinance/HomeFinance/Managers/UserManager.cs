using System;
using System.Collections.Generic;
using System.Text;
using HomeFinance.Model;
using HomeFinance.Model.DataUser;

namespace HomeFinance.Managers
{
    public class UserManager
    {
        private readonly DatabaseConnection databaseConnection;
        //Logika pro držení údajů aktuálního uživatele
        public UserManager(DatabaseConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }
        public User AutenticateUser(string username, string password)
        {
            var user = databaseConnection.GetUserByName(username);
            if (password == user.Password)
            {
                Data.UserData.LoggedUser = user;
                return user;
            }
            else return null;
        }
    }
}
