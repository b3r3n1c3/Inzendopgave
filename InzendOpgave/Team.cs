using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InzendOpgave.Views
{
    class Teams
    {

        public Team[] _Team { get; set; }

        public static Teams GetTeams()
        {
            Team[] TeamsArray = new Team[3];
            TeamsArray[0] = new Team("Natus Vincere", 2009);
            TeamsArray[1] = new Team("Ninjas in Pyjama's", 2000);
            TeamsArray[2] = new Team("Astralis", 2016);

            Teams Teams = new Teams()
            {
                _Team = TeamsArray
            };

            return Teams;
        }
    }
}
