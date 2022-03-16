using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InzendOpgave.Views
{
   public  class Team
    {
        public string TeamName { get; set; }
        public int StartYear { get; set; }

        public Team(string teamName, int teamYear)
        {
            TeamName = teamName;
            StartYear = teamYear;
        }
 //This is what get does
        public string getTeamName()
        {
            return this.TeamName;
        }
//This is what set does
        public string setTeamname(string newTeamName)
        {
            return this.TeamName = newTeamName;
        }

    }
}
