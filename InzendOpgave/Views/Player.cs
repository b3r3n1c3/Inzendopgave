using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InzendOpgave.Views
{
    class Player : TeamMember
    {
        string Role; 
        int Kills = 0;
        int Deaths = 0;
        float KD = 0; 

        public Player(string playerRole, string memberName, int memberAge, string memberInGameName) : base (memberName, memberAge, memberInGameName)
        {
            Role = playerRole;
        }

        public float GetKD(int Kills, int Deaths)
        {
            this.KD = Kills / Deaths;
            return KD;
        }
        public void AddKill()
        {
            this.Kills++;
            Console.WriteLine($"Kill Confirmed, Total kills: {this.Kills}");
        }

        public void AddDeath()
        {
            this.Deaths++;
            Console.WriteLine($"You died! Total Deaths : {this.Kills}");
        }


    }
}
