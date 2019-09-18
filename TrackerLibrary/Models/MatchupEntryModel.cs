using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team on the match up
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the scores for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the matchup that this tame came 
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        
    }
}
