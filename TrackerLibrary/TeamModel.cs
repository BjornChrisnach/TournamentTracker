using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        // default uninitialized List, so add = new List<Person>();
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }

        // Since c# 6.0, you can do it with the property and not more in the constructor
        //public TeamModel()
        //{
        //    TeamMembers = new List<Person>();
        //}

    }
}
