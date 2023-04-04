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
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }

            if (textFiles)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);

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