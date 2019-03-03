using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;
using Pieces;
using BuildingBlocks;
using Game_Defination;

namespace The_Queen
{
    public abstract class Game : IUpdate
    {
        protected Dictionary<int, float> _markAllocation;
        protected List<Player> _players;
        protected List<TraceType> _traceTypes;
        protected Dictionary<int, int> _switchingTimes;
        
        protected Music currentMusic;
        protected Rhythm currentRhythm;

        protected CoordinateSystem coordinateSystem;
        protected HashSet<KingEnvironment> environments;

        protected Game()
        {

        }

        protected Game(Dictionary<int, float> _markAllocation, List<Player> _players, List<TraceType> _traceTypes, 
        Dictionary<int, int> _switchingTimes, CoordinateSystem coordinateSystem, Rhythm currentRhythm)
        {

        }

        protected Game(Dictionary<int, float> _markAllocation, List<Player> _players, List<TraceType> _traceTypes,
        Dictionary<int, int> _switchingTimes, CoordinateSystem coordinateSystem, Music currentMusic)
        {

        }

        protected Game(Dictionary<int, float> _markAllocation, List<Player> _players, List<TraceType> _traceTypes,
        Dictionary<int, int> _switchingTimes, CoordinateSystem coordinateSystem, Music currentMusic, Rhythm currentRhythm)
        {

        }

        public Dictionary<int, float> MarkAllocation { get; set; }

        public List<Player> Players { get; set; }

        public TraceType TraceType { get; set; }

        public Dictionary<int, float> SwitchingTimes { get; set; }

        public Music CurrentMusic { get; set; }


        protected Point RequestQueenPosition(int thinkingTime)
        {
            Point playerAnswer = null;

            return playerAnswer;
        }

        protected IDirection RequestQueenDirection(int thinkingTime)
        {
            IDirection playerAnswer = null;

            return playerAnswer;
        }

        protected KingDirection RequestKingDirection(int thinkingTime)
        {
            KingDirection playerAnswer = KingDirection.FACING_FRONT;

            return playerAnswer;
        }

        public void SetMarksAllocation(int thinkingTime, float mark)
        {

        }

        protected void TakePlayersAnswers()
        {

        }

        protected bool IsQuestionAllowed(TraceType traceType)
        {
            return true;
        }

        public void RemoveNPlayer(int numberOfPlayers)
        {

        }

        public void AddPlayer(Player Player)
        {

        }

        public void RemovePlayer(string playerId)
        {

        }

        public void RetrieveChoosenKingStep()
        {

        }

        public void RetrieveChoosenMultiple()
        {

        }

        public void RetrieveChoosenMovingStrategy()
        {

        }

        public void RetrieveChoosenRhythm()
        {

        }

        public void RetrieveChoosenMusic()
        {

        }

        public void AddTraceType(TraceType traceType)
        {

        }

        public void RemovTraceType(TraceType traceType)
        {

        }



        public void StartGame()
        {

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
