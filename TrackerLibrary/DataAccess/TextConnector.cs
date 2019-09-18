using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            model.Id = 1;

            return model;
        }

        //TO DO - Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            throw new NotImplementedException();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }
    }
}
