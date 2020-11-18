using System;
using System.Collections.Generic;
using System.Web;

namespace ASPNet
{
    public class Invoice
    {
        private string invoiceId;

        private decimal amount;

        private Currency currency;

        private DateTime createDate;

        private DateTime modifyDate;

        public string InvoiceId { get => invoiceId; set => invoiceId = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public Currency Currency { get => currency; set => currency = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public DateTime ModifyDate { get => modifyDate; set => modifyDate = value; }
    }
}