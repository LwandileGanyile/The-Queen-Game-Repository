using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Queen;
using MusicPattern;

namespace Tertiary_Queen
{
    public class TertiaryQueen : Queen
    {
        private ITertiaryMovingStrategy tertiaryMovingStrategy;
        private ITertiaryShootingStrategy tertiaryShootingStrategy;


        public TertiaryQueen()
        {

        }

        public TertiaryQueen(ITertiaryMovingStrategy tertiaryMovingStrategy)
        {

        }

        public TertiaryQueen(ITertiaryShootingStrategy tertiaryShootingStrategy)
        {

        }


        public TertiaryQueen(ITertiaryMovingStrategy tertiaryMovingStrategy, ITertiaryShootingStrategy tertiaryShootingStrategy)
        {

        }


        public TertiaryQueen(ITertiaryMovingStrategy teriaryMovingStrategy, Rhythm rhythm)
        {

        }

        public TertiaryQueen(ITertiaryMovingStrategy teriaryMovingStrategy, Rhythm rhythm, ITertiaryShootingStrategy tertiaryShootingStrategy)
        {

        }
    }
}
