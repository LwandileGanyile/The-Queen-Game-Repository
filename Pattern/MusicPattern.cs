using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;

namespace Pattern
{
    public class MusicPattern : GamePattern, IGamePattern<Music>
    {
        private List<Music> musicList;

        public MusicPattern()
        {

        }

        public MusicPattern(List<Music> musicList)
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
