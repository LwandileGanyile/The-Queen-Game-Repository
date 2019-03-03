using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Queen;

namespace Tertiary_Queen
{
    public class TertiaryPlayer : Player
    {
        private Intelligence playerIntelligence;


        public Intelligence PlayerIntelligence
        {
            get; set;
        }



        public TertiaryPlayer()
        {

        }

        public TertiaryPlayer(Intelligence playerIntelligence)
        {

        }

        public TertiaryPlayer(string playerId, string playerName, string playerSurname)
        {

        }

        public TertiaryPlayer(Intelligence intelligence, string playerId, string playerName, string playerSurname)
        {

        }

    }
}
