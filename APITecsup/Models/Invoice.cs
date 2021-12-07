using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Number { get; set; }
        public int Total { get; set; }
        public List<Detail>  Details { get; set; }

    }
}