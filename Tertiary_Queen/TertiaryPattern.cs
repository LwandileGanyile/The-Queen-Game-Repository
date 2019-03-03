using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern;
using MusicPattern;
using The_Queen;

namespace Tertiary_Queen
{
    public class TertiaryPattern
    {
        protected ITertiaryMovingStrategy move;
        protected ITertiaryShootingStrategy shoot;
        protected KingStep kingStep;

        protected TertiaryPattern()
        {

        }

        protected TertiaryPattern(ITertiaryMovingStrategy move)
        {

        }

        protected TertiaryPattern(ITertiaryShootingStrategy shoot)
        {

        }

        protected TertiaryPattern(KingStep kingStep)
        {

        }

        protected TertiaryPattern(ITertiaryMovingStrategy move, ITertiaryShootingStrategy shoot)
        {

        }

        protected TertiaryPattern(ITertiaryMovingStrategy move, KingStep kingStep)
        {

        }

        protected TertiaryPattern(ITertiaryMovingStrategy move,ITertiaryShootingStrategy shoot, KingStep kingStep)
        {

        }



    }
}
