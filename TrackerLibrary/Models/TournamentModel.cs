using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>f
        /// The unique identifier for the Tournamnet 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the Entry fee to the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represent the list of teams competing in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// represent the list of prices for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents how many rounds the tournaments is compoused by
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
