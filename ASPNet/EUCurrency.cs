using System;
using System.Collections.Generic;
using System.Web;

namespace ASPNet
{
    public class EUCurrency : Currencies
    {
        public string getCurrency()
        {
            throw new NotImplementedException();
        }

        public string getSymbol()
        {
            return GlobalParameter.EUR;
        }
    }
}