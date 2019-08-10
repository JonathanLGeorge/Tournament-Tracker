using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    /// <summary>
    /// This is one match in tournament
    /// </summary>
    public class MatchupModel
    {

      /// <summary>
      /// This list of teams that competed in this match
      /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// the round this match was apart of 
        /// </summary>
        public int MatchupRound { get; set; }

        /// <summary>
        /// the winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
    }
}
