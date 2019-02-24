using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;

namespace Pattern
{
    public class RhythmPattern : GamePattern, IGamePattern<Rhythm>
    {
        private List<Rhythm> rhythms;

        protected RhythmPattern()
        {

        }

        protected RhythmPattern(List<Rhythm> rhythms)
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
