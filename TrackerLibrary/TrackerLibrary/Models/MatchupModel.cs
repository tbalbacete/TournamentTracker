using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// represents the teams entered into the Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the winner of the Matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents which round this matchup is
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
