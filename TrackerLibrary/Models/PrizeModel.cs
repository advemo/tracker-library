using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
   public class PrizeModel
    {   
        /// <summary>f
        /// The unique identifier for the prize 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the place number for identification 
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents how mush is the price
        /// </summary>
        public decimal PriceAmount { get; set; }

        /// <summary>
        /// Represents the the percents the price is from the total
        /// </summary>
        public double PricePercent { get; set; }

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
            PriceAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PricePercent = prizePercentageValue;

        }
    }
}
