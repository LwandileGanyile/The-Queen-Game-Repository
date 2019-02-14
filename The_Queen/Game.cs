using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;

namespace The_Queen
{
    public class Game
    {
        private Dictionary<int, float> _markAllocation;
        private List<Player> _players;
        private TraceType _traceType;
        private Dictionary<int, int> _switchingTimes;
        private Music currentMusic;

        public Game()
        {

        }

        public Game(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType, 
        Dictionary<int, int> _switchingTimes)
        {

        }

        public Game(Dictionary<int, float> _markAllocation, List<Player> _players, TraceType _traceType,
        Dictionary<int, int> _switchingTimes, Music currentMusic)
        {

        }

        public Dictionary<int, float> MarkAllocation { get; set; }

        public List<Player> Players { get; set; }

        public TraceType TraceType { get; set; }

        public Dictionary<int, float> SwitchingTimes { get; set; }

        public Music CurrentMusic { get; set; }




    }
}
