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
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            //this line takes our file name, converts it to full path using app.config, loads the file if it exists..
            //(..and if it doesn't exist returns back an empty list, takes the list and converts it to a list of PersonModel
            //If the list is empty, we get an empty list of PersonModel, otherwise we get a list of all the people in our CSV file
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //next we need to find the max id
            int currentId = 1;

            if (PeopleFile.Count > 0)
            {
                //order people list descending by id, take the first one, take its id, add 1 to it, and thats the value of the current id
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
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

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        //here we can implement an interface(?):
        public List<PersonModel> GetPerson_All() 
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
        
        }

    }
}
