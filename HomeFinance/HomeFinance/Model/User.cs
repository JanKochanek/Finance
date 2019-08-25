﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HomeFinance.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CisloUctu { get; set; }
    }
}
