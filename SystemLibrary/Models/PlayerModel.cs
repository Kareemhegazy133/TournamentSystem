using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.Models
{
    /// <summary>
    /// Represents a player.
    /// </summary>
    public class PlayerModel
    {

        /// <summary>
        /// The unique indentifier for the player
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the player.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the player.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of the player.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The Cellphone number of the player.
        /// </summary>
        public string CellphoneNumber { get; set; }

        /// <summary>
        /// The Fullname of the player.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
