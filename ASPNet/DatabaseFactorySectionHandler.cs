using System;
using System.Collections.Generic;
using System.Web;
using System.Configuration;

/*
 * http://www.primaryobjects.com/2007/11/16/implementing-a-database-factory-pattern-in-c-asp-net/
 */
namespace ASPNet
{
    public class DatabaseFactorySectionHandler : ConfigurationSection
    {
        [ConfigurationProperty("Name")]
        public string Name
        {
            get { return (string)base["Name"]; }
        }

        [ConfigurationProperty("ConnectionStringName")]
        public string connectionStringName
        {
            get { return (string)base["ConnectionStringName"]; }
        }

        public string ConnectionString
        {
            get
            {
                try
                {
                    return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
                }
                catch(Exception ex)
                {
                    throw new Exception("Connection string " + connectionStringName + " was not found in web.config. " + ex.Message)
;                }
            }
        }
    }
}