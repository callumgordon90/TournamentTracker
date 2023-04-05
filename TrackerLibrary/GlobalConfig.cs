using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{

    /// <summary>
    /// This class is responsible for the configurartion of database connections
    /// </summary>
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }


        //"Void" is used as the return type of a method in order to specify that the method doesn't return a value.
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;

            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text ;

            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //Now, whenever anyone types in GlobalConfig.CNNString and passes in 'tournaments' as the parameter,
        //They will get the string above returned back to them
    }
}
// above there are two options for database connection: textfiles and SQL