using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Queen;
using MusicPattern;
using BuildingBlocks;
using Pieces;

namespace Tertiary_Queen
{
    public class TertiaryGame : Game
    {
        public TertiaryGame()
        {

        }

        protected TertiaryGame(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, R3Plane plane, Rhythm currentRhythm)
        {

        }

        protected TertiaryGame(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, R3Plane plane, Music currentMusic)
        {

        }

        protected TertiaryGame(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, R3Plane plane, Rhythm currentRhythm, Music currentMusic)
        {

        }

        protected ILetter RequestQueenLetter(int thinkingTime)
        {
            ILetter playerAnswer = null;

            return playerAnswer;
        }


        protected R3Function RequestQueenFunction(int thinkingTime)
        {
            R3Function playerAnswer = null;

            return playerAnswer;
        }

        protected HashSet<IDirection> RequestQueenVectors(int thinkingTime)
        {
            HashSet<IDirection> playerAnswer = null;

            return playerAnswer;
        }

        protected R3Plane RequestQueenPlane(int thinkingTime)
        {
            R3Plane playerAnswer = null;

            return playerAnswer;
        }

        public void RetrieveChoosenVectorShootingStrategy()
        {

        }

        public void RetrieveChoosenPlaneShootingStrategy()
        {

        }

        public void RetrieveChoosenFunctionShootingStrategy()
        {

        }
    }
}
