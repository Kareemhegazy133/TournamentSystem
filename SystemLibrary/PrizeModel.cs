using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary
{
    /// <summary>
    /// Represents the prize of the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The place number of the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The place name of the prize.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The prize amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
