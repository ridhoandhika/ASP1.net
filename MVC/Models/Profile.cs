﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string NamaLengkap { get; set; }
        public string Alamat { get; set; }
        public string Hobi { get; set; }
    }
}