using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    //api/transaction/getAllTransactions
    public class TransactionController : ApiController
    {
        Payment[] payments = new Payment[]
        {
            new Payment { id = "Inv001", payment = "100.00 EUR", Status = "R" },
            new Payment { id = "Inv007", payment = "450.00 SGD", Status = "A" },
            new Payment { id = "Inv009", payment = "340.00 EUR", Status = "R" },
            new Payment { id = "Inv011", payment = "80.00 USD", Status = "D" },
        };
        public IEnumerable<Payment> GetAllTransactions()
        {
            return payments;
        }
    }
}
