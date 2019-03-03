using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;
using Game_Defination;

namespace The_Queen
{
    public class KingEnvironment : IUpdate
    {
        private List<King> kings;

        private HashSet<MusicMood> moods;
        private HashSet<MusicGenre> genres;
        private HashSet<MusicInstrument> instruments;
        private HashSet<KingStep> steps;

        public KingEnvironment()
        {

        }


        public KingEnvironment(List<King> kings)
        {

        }

        public KingEnvironment(HashSet<KingStep> steps)
        {

        }

        public KingEnvironment(HashSet<MusicInstrument> instruments)
        {

        }

        public KingEnvironment(HashSet<MusicMood> moods)
        {

        }

        public KingEnvironment(HashSet<MusicGenre> genres)
        {

        }

        public KingEnvironment(HashSet<KingStep> steps, HashSet<MusicMood> moods, HashSet<MusicGenre> genres, HashSet<MusicInstrument> instruments)
        {

        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
