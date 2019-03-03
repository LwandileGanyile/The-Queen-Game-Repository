using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Queen;
using MusicPattern;
using BuildingBlocks;
using Pieces;

namespace Secondary_Queen
{
    public class SecondaryGame : Game
    {
        public SecondaryGame()
        {

        }

        protected SecondaryGame(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, CartesianPlane cartesianPlane, Rhythm currentRhythm)
        {

        }

        protected SecondaryGame(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, CartesianPlane cartesianPlane, Music currentMusic)
        {

        }

        protected SecondaryGame(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, CartesianPlane cartesianPlane, Rhythm currentRhythm, Music currentMusic)
        {

        }

        protected ILetter RequestQueenLetter(int thinkingTime)
        {
            ILetter playerAnswer = null;

            return playerAnswer;
        }


        protected R2Function RequestQueenFunction(int thinkingTime)
        {
            R2Function playerAnswer = null;

            return playerAnswer;
        }

        protected HashSet<IDirection> RequestQueenVectors(int thinkingTime)
        {
            HashSet<IDirection> playerAnswer = null;

            return playerAnswer;
        }

        public void RetrieveChoosenShootingStrategy()
        {

        }
   
    }
}
