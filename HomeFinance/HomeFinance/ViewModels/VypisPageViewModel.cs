using System;
using System.Collections.Generic;
using System.Text;
using HomeFinance.Model;

namespace HomeFinance.ViewModels
{
    public class VypisPageViewModel : Abstract.AbstractViewModel
    {
        private DatabaseConnection db;
        public VypisPageViewModel()
        {
            db = new DatabaseConnection();
            Prijmy = db.ReturnPrijem();
            Vydaje = db.ReturnVydaj();
        }
        public List<Prijem> Prijmy { get; set; }
        public List<Vydaj> Vydaje { get; set; }
           
    }
}
