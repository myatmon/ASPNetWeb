using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ASPNet
{
    public class Utility
    {
        public bool CheckExtension(string contentType)
        {
            return contentType == "application/vnd.ms-excel" || contentType == "application/xml";
        }

        public bool CheckMaxLength(int length)
        {
            return length < 102400;
        }

        public string getType(string contentType)
        {
            switch (contentType)
            {
                case GlobalParameter.XLS_TYPE:
                    return GlobalParameter.XLS;
                    break;
                case GlobalParameter.XML_TYPE:
                    return GlobalParameter.XML;
                    break;
            }
        }
    }
}
