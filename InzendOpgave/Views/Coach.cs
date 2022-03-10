using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InzendOpgave.Views
{

                    
    class Coach : TeamMember
    {
        int TacticalTimeouts = 4;
        public Coach(string memberName, int memberAge, string memberInGameName) : base(memberName, memberAge, memberInGameName)
        {
            Console.WriteLine("HELP");
        }



        public void UseTacticalTimeout()
        {
            if (this.TacticalTimeouts > 0)
            {
                this.TacticalTimeouts--;
                Console.WriteLine($"Tactical Timeout used, {TacticalTimeouts} Tactical Timeouts left. ");
            }

            else
            {
                Console.WriteLine("No Tactical Timeouts left, n00b GG");
            }
        }
         
        public void MotivatePlayer(Player player)
        {
            Console.WriteLine($"Come on {player.InGameName}, u can do it!");
        }
    }
}
