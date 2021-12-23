using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.Models
{
    /// <summary>
    /// Represents a team in the tournament.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// The team members of the team.
        /// </summary>
        public List<PlayerModel> TeamMembers { get; set; } = new List<PlayerModel>();

        /// <summary>
        /// The name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
