using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern;
using MusicPattern;

namespace Primary_Queen
{
    public class PrimaryMusicPattern : IGamePattern<Music>
    {
        private IPrimaryMovingStrategy movingStrategy;
        private RhythmPattern rhythmPattern;

        public PrimaryMusicPattern()
        {

        }

        public PrimaryMusicPattern(IPrimaryMovingStrategy movingStrategy, RhythmPattern rhythmPattern)
        {

        }

        public void Remove(int index)
        {
            throw new NotImplementedException();
        }

        public Music RetrieveCurrent()
        {
            throw new NotImplementedException();
        }

        public Music RetrieveNext()
        {
            throw new NotImplementedException();
        }

        public Music RetrievePrevious()
        {
            throw new NotImplementedException();
        }
    }
}
