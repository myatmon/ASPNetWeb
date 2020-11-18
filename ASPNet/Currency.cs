using System;
using System.Collections.Generic;
using System.Web;

namespace ASPNet
{
    public class Currency
    {
        private string currencyID;

        private string currencyCode;

        private string currencyName;

        private string createDate;

        private string modifyDate;

        public string CurrencyID { get => currencyID; set => currencyID = value; }
        public string CurrencyCode { get => currencyCode; set => currencyCode = value; }
        public string CurrencyName { get => currencyName; set => currencyName = value; }
        public string CreateDate { get => createDate; set => createDate = value; }
        public string ModifyDate { get => modifyDate; set => modifyDate = value; }
    }
}