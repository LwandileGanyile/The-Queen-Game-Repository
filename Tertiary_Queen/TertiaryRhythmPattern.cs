using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;
using Pattern;
using The_Queen;

namespace Tertiary_Queen
{
    public class TertiaryRhythmPattern : TertiaryPattern, IGamePattern<Rhythm>
    {
        private RhythmPattern rhythmPattern;

        public TertiaryRhythmPattern()
        {

        }

        public TertiaryRhythmPattern(ITertiaryMovingStrategy move, RhythmPattern rhythmPattern)
        {

        }

        public TertiaryRhythmPattern(ITertiaryShootingStrategy shoot, RhythmPattern rhythmPattern)
        {

        }

        public TertiaryRhythmPattern(KingStep kingDance, RhythmPattern rhythmPattern)
        {

        }

        public TertiaryRhythmPattern(ITertiaryMovingStrategy move, ITertiaryShootingStrategy shoot, RhythmPattern rhythmPattern)
        {

        }

        public TertiaryRhythmPattern(ITertiaryMovingStrategy move, KingStep kingDance, RhythmPattern rhythmPattern)
        {

        }

        public TertiaryRhythmPattern(ITertiaryMovingStrategy move, ITertiaryShootingStrategy shoot, KingStep kingDance, RhythmPattern rhythmPattern)
        {

        }

        public void Remove(int index)
        {
            throw new NotImplementedException();
        }

        public Rhythm RetrieveCurrent()
        {
            throw new NotImplementedException();
        }

        public Rhythm RetrieveNext()
        {
            throw new NotImplementedException();
        }

        public Rhythm RetrievePrevious()
        {
            throw new NotImplementedException();
        }
    }
}
