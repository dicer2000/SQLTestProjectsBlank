using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SQLWebApp
{
    public class DBAccess
    {
        private string _connection = String.Empty;

        public DBAccess()
        {
            this._connection = ConfigurationManager.AppSettings["ConnectionString"];
            if (string.IsNullOrEmpty(this._connection))
                throw new Exception("No Connection String is defined in configuration");
        }

        public DBAccess(string ConfigurationString)
        {
            this._connection = ConfigurationString;
        }
    }
}