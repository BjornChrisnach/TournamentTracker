using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        public String FirstName { get; set; }
        
        public String LastName { get; set; }
        
        public String EmailAddress { get; set; }
        
        public String CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
