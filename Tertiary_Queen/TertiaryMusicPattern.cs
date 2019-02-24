using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern;
using The_Queen;

namespace Tertiary_Queen
{
    public class TertiaryMusicPattern
    {
        private Pattern.MusicPattern musicPattern;

        public TertiaryMusicPattern()
        {

        }

        public TertiaryMusicPattern(ITertiaryMovingStrategy move, Pattern.MusicPattern musicPattern)
        {

        }

        public TertiaryMusicPattern(ITertiaryShootingStrategy shoot, Pattern.MusicPattern rhythmPattern)
        {

        }

        public TertiaryMusicPattern(KingStep kingDance, Pattern.MusicPattern musicPattern)
        {

        }

        public TertiaryMusicPattern(ITertiaryMovingStrategy move, ITertiaryShootingStrategy shoot, Pattern.MusicPattern musicPattern)
        {

        }

        public TertiaryMusicPattern(ITertiaryMovingStrategy move, KingStep kingDance, Pattern.MusicPattern musicPattern)
        {

        }

        public TertiaryMusicPattern(ITertiaryMovingStrategy move, ITertiaryShootingStrategy shoot, KingStep kingDance, Pattern.MusicPattern musicPattern)
        {

        }
    }
}
