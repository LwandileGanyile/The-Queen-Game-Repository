using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Queen;
using MusicPattern;

namespace Secondary_Queen
{
    public class SecondaryQueen : Queen
    {
        private ISecondaryMovingStrategy primaryMovingStrategy;


        public SecondaryQueen()
        {

        }

        public SecondaryQueen(ISecondaryMovingStrategy primaryMovingStrategy)
        {

        }

        public SecondaryQueen(ISecondaryMovingStrategy primaryMovingStrategy, Rhythm rhythm)
        {

        }
    }
}
