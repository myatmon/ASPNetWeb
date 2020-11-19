using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi
{
    public class Invoice
    {
        public string invoiceId { get; set; }
        public decimal amount { get; set; }
        public DateTime datetTime { get; set; }
    }
}