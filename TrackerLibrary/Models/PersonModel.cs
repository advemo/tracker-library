using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>f
        /// The unique identifier for the person 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents The First name of the person compeating
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents The Last Name of the person competing
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents The email adreess of the person competing
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents The phone number of the person competing
        /// </summary>
        public string CellphoneNumber { get; set; }

       
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }

}
