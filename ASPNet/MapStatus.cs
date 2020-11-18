using System;
using System.Collections.Generic;
using System.Web;

namespace ASPNet
{
    public class MapStatus
    {
        public string getStatus(string value)
        {
            return getMap()[value];
        }

        private Dictionary<String,String> getMap()
        {
            var map = new Dictionary<string, string>();
            map.Add(GlobalParameter.APPROVED, GlobalParameter.A);
            map.Add(GlobalParameter.FAILED, GlobalParameter.R);
            map.Add(GlobalParameter.REJECTED, GlobalParameter.R);
            map.Add(GlobalParameter.FINISHED, GlobalParameter.D);
            map.Add(GlobalParameter.DONE, GlobalParameter.D);
            return map;
        }
    }
}