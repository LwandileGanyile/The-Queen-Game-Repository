using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPattern
{
    public class Rhythm
    {
        private Dictionary<int, int> _rhythmStructure;
        private List<bool> _ignoreClaps;
        private bool isComputerGenerated;

        public Rhythm()
        {

        }

        public Rhythm(Dictionary<int, int> _rhythmStructure, List<bool> _ignoreClaps, bool isComputerGenerated)
        {

        }

        public Dictionary<int, int> RhythmStructure { get; set; }

        public List<bool> IgnoreClaps { get; set; }

        public bool IsComputerGenerated { get; set; }

        public void SetClapsAt(int atTime, int numberOfClaps)
        {

        }

        public void AddClapsAt(int atTime, int numberOfClaps)
        {

        }

        public bool RemoveClapsAt(int atTime)
        {
            return true;
        }

        public bool ShiftRhythmLeft(int timeInMilliSeconds)
        {
            return true;
        }

        public bool ShiftRhythmRight(int timeInMilliSeconds)
        {
            return true;
        }

        public bool ShiftClapsRight(int timeInMilliSeconds)
        {
            return true;
        }

        public bool ShiftClapsLeft(int timeInMilliSeconds)
        {
            return true;
        }

        public void SetClap(int clapIndex, bool ignore)
        {

        }

        public bool IsIdentical(Rhythm anotherRhythm)
        {
            return true;
        }

        public void ConcatenateRhythm(Rhythm anotherRhythm, int timeInBetween)
        {

        }

    }
}
