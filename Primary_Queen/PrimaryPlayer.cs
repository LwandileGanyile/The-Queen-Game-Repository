using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Queen;

namespace Primary_Queen
{
    public class PrimaryPlayer : Player
    {
        private PrimaryMovingStrategyIntelligence playerIntelligence;


        public PrimaryMovingStrategyIntelligence PlayerIntelligence
        {
            get;set;
        }

        

        public PrimaryPlayer()
        {

        }

        public PrimaryPlayer(PrimaryMovingStrategyIntelligence intelligence)
        {

        }

        public PrimaryPlayer(string playerId, string playerName, string playerSurname)
        {

        }

        public PrimaryPlayer(PrimaryMovingStrategyIntelligence intelligence, string playerId, string playerName, string playerSurname)
        {

        }

        public void ChooseCPrimaryMovingStrategy()
        {

        }

        public void ChooseNCPrimaryMovingStrategy()
        {

        }
    }
}
