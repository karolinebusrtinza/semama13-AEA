using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public Invoice Invoice { get; set; }
    }
}