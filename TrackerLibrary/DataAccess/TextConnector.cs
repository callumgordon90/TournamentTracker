using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess 
{
    public class TextConnector : IDataConnection
    {
        //This is the location where we are going to store our prizes
        private const string PrizesFile = "PrizeModels.csv";


        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
        }


        // TODO - Wire up the CreatePrize for the text files
        //The following are helper methods which will allow us to talk to the text files:
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);

            // Convert the prizes to list<string>

            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
