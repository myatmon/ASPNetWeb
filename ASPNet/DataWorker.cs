using System;
using System.Collections.Generic;
using System.Web;
/*
 * http://www.primaryobjects.com/2007/11/16/implementing-a-database-factory-pattern-in-c-asp-net/
 */
namespace ASPNet
{
    public class DataWorker
    {
        private static Database _database = null;

        static DataWorker()
        {
            try
            {
                _database = DatabaseFactory.CreateDatabase();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static Database database
        {
            get { return _database; }
        }
    }
}