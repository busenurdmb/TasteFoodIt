﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entity
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string Tel { get; set; }
    }
}