using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier for the team
        /// </summary>
        public int Id { get; set; }

        public string TeamName { get; set; }

        // default uninitialized List, so add = new List<Person>();
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        // Since c# 6.0, you can do it with the property and you don(t need to do it
        // in the constructor
        //public TeamModel()
        //{
        //    TeamMembers = new List<Person>();
        //}

    }
}
