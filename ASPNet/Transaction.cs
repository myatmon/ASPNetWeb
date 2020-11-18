using System;
using System.Collections.Generic;
using System.Web;

namespace ASPNet
{
    public class Transaction
    {
        private List<Transaction> transactions;

        private string transactionID;

        private string transactionStatus;

        private DateTime transactionDate;

        private DateTime createDate;

        private DateTime modifyDate;

        private Invoice invoice;

        public List<Transaction> Transactions { get => transactions; set => transactions = value; }
        public string TransactionID { get => transactionID; set => transactionID = value; }
        public string TransactionStatus { get => transactionStatus; set => transactionStatus = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public DateTime ModifyDate { get => modifyDate; set => modifyDate = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
    }
}