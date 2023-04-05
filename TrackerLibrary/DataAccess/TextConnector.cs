using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess 
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for the text files
        //The following are helper methods which will allow us to talk to the text files:
        public PrizeModel CreatePrize(PrizeModel model)
        {
             // Load the text file
             // Convert the text to List <PrizeModel>
             // Find the ID
             // Add the new record with the new ID (max + 1)
             // Convert the prizes to list<string>
             // Save the list<string> to the text file
        }
    }
}
