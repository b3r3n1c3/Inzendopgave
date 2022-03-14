using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InzendOpgave.Views
{
    class TeamMember
    {
        string Name;
        int Age;
       public  string InGameName;


    public TeamMember(string memberName, int memberAge, string memberInGameName)
        {
            Name = memberName;
            Age = memberAge;
            InGameName = memberInGameName;
        }
    }

}
