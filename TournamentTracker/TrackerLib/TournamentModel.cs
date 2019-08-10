using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLib
{
    public class TournamentModel
    {
        /// <summary>
        /// Name you wish to give the Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Value for the entry fee
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of Teams that can be in the tournament 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of Prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// complet list of all the matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
