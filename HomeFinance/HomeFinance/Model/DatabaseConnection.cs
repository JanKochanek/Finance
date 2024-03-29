﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;
using HomeFinance.Model.DataUser;

namespace HomeFinance.Model
{
    public class DatabaseConnection
    {
        private SQLiteConnection dbConnection;
        public DatabaseConnection()
        {
            //Cesta k Lokálnímu úložišti pro databázy
            dbConnection = new SQLiteConnection(Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            "userdata.db3"));

            dbConnection.CreateTable<User>();
            dbConnection.CreateTable<Prijem>();
            dbConnection.CreateTable<Vydaj>();
        }

        public void RegisterUserToDB(User user)
        {
            dbConnection.Insert(user);
        }
        public List<User> ReturnAllUsers()
        {
            var users = dbConnection.Table<User>().ToList();
            return users;
        }
        public User GetUserByName(string username)
        {
            return dbConnection.Table<User>().Where(user => user.Username == username).FirstOrDefault();
        }
        public void AddPrijem(Prijem prijem)
        {
            dbConnection.Insert(prijem);
        }
        public void AddVydaj(Vydaj vydaj)
        {
            dbConnection.Insert(vydaj);
        }
        public List<Prijem> ReturnPrijem()
        {
            var prijmy = dbConnection.Table<Prijem>().Where(prijem => prijem.Id == Data.UserData.LoggedUser.Id).ToList();
            return prijmy;
        }
        public List<Vydaj> ReturnVydaj()
        {
            var vydaje = dbConnection.Table<Vydaj>().Where(vydaj => vydaj.Id == Data.UserData.LoggedUser.Id).ToList();
            return vydaje;
        }
    }
}
