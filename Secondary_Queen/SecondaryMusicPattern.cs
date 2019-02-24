using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern;
using MusicPattern;


namespace Secondary_Queen
{
    public class SecondaryMusicPattern : SecondaryPattern, IGamePattern<Music>
    {
        
        private Pattern.MusicPattern musicPattern;

        public SecondaryMusicPattern()
        {

        }

        public SecondaryMusicPattern(ISecondaryMovingStrategy move, Pattern.MusicPattern musicPattern)
        {

        }

        public SecondaryMusicPattern(ISecondaryShootingStrategy shoot, Pattern.MusicPattern musicPattern)
        {

        }

        public SecondaryMusicPattern(ISecondaryMovingStrategy move, ISecondaryShootingStrategy shoot, Pattern.MusicPattern musicPattern)
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

        Music IGamePattern<Music>.RetrieveCurrent()
        {
            throw new NotImplementedException();
        }

        Music IGamePattern<Music>.RetrieveNext()
        {
            throw new NotImplementedException();
        }

        Music IGamePattern<Music>.RetrievePrevious()
        {
            throw new NotImplementedException();
        }
    }
}
