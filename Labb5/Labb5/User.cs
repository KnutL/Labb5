﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class User
    {
        public string Namn { get; set; }
        public string Epost { get; set; }
        
        public User(string Namn, string Epost)
        {
            Namn = this.Namn;
            Epost = this.Epost;
        }
    }
}
