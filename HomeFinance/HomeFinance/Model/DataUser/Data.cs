using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFinance.Model.DataUser
{
    public class Data
    {
        public static Data UserData = new Data();

        public User LoggedUser { get; set; }
    }
}
