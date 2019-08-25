using System;
using System.Collections.Generic;
using System.Text;
using HomeFinance.Model;

namespace HomeFinance.ViewModels
{
    public class VypisPageViewModel : Abstract.AbstractViewModel
    {
        public VypisPageViewModel()
        {

        }
        public List<Prijem> Prijmy { get; set; }
        public List<Vydaj> Vydaje { get; set; }
           
    }
}
