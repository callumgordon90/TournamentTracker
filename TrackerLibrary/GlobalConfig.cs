using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{

    /// <summary>
    /// This class is responsible for the configurartion of database connections
    /// </summary>
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); 

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
                TextConnection text = new TextConnection();
                Connections.Add(text);

            }
        }
    }
}
// above there are two options for database connection: textfiles and SQL