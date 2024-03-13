﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entity
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    public DateTime SendDate { get; set; }
    }
}