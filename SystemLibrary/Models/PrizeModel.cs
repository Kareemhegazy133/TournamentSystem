using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.Models
{
    /// <summary>
    /// Represents the prize of the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique indentifier for the prize
        /// </summary>
        public int Id { get; set; }

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

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
