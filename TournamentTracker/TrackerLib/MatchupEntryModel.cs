using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
   public class MatchupEntryModel
    {
        /// <summary>
        /// One team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Score for this specific team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// THe matchup that the team just came from 
        /// previously as the winner!
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        
    }
}
