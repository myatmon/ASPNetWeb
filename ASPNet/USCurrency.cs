using System;
using System.Collections.Generic;
using System.Web;

namespace ASPNet
{
    public class USCurrency : Currency
    {
        public string getCurrency()
        {
            throw new NotImplementedException();
        }

        public string getSymbol()
        {
            return GlobalParameter.USD;
        }
    }
}