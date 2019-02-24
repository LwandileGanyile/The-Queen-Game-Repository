using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;

namespace The_Queen
{
    public abstract class Game
    {
        protected Dictionary<int, float> _markAllocation;
        protected List<Player> _players;
        protected TraceType _traceType;
        protected Dictionary<int, int> _switchingTimes;
        protected Music currentMusic;
        protected CoordinateSystem coordinateSystem;

        protected Game()
        {

        }

        protected Game(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType, 
        Dictionary<int, int> _switchingTimes, CoordinateSystem coordinateSystem)
        {

        }

        protected Game(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, Music currentMusic, CoordinateSystem coordinateSystem)
        {

        }

        public Dictionary<int, float> MarkAllocation { get; set; }

        public List<Player> Players { get; set; }

        public TraceType TraceType { get; set; }

        public Dictionary<int, float> SwitchingTimes { get; set; }

        public Music CurrentMusic { get; set; }




    }
}
