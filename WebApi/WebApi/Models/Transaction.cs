using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Transaction
    {
        Transaction()
        {

        }
        public string transactionId { get; set; }
        public DateTime transactionDate { get; set; }
        public Invoice invoice { get; set; }
        public string status { get; set; }        
    }
}