using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Web;

/*
 * http://www.primaryobjects.com/2007/11/16/implementing-a-database-factory-pattern-in-c-asp-net/
 */
namespace ASPNet
{
    public sealed class DatabaseFactory
    {
        public static DatabaseFactorySectionHandler sectionHandler = (DatabaseFactorySectionHandler)ConfigurationManager.GetSection("DatabaseFactoryConfiguration");
        private DatabaseFactory() { }

        public static Database CreateDatabase()
        {
            if(sectionHandler.Name.Length == 0)
            {
                throw new Exception("Database name not found!");
            }

            try
            {
                Type database = Type.GetType(sectionHandler.Name);

                ConstructorInfo constructor = database.GetConstructor(new Type[] { });

                Database createObject = (Database)constructor.Invoke(null);

                createObject.connectionString = sectionHandler.ConnectionString;

                return createObject;


            }
            catch(Exception ex)
            {
                throw new Exception("Error instantiating database  " + sectionHandler.Name + " :: " + ex.Message);
            }
        }

    }
}