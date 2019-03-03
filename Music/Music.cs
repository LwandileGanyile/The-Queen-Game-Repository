using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace MusicPattern
{
    public class Music : IUpdate
    {
        private HashSet<MusicMood> _moods;
        private HashSet<MusicDance> _dances;
        private HashSet<MusicGenre> _genres;
        private HashSet<MusicInstrument> _instruments;

        private List<Rhythm> _rhythms;
        private int _currentRhythmIndex;
        private bool _repeatMusic;

        private string _musicLocation;
        private int _musicDuration;



        public Music()
        {

        }

        public Music(int _musicDuration, List<Rhythm> _rhythms, int _currentRhythmIndex, string _pathOfMusic, bool _repeatMusic)
        {

        }

        public Music(int _musicDuration, List<Rhythm> _rhythms, int _currentRhythmIndex, string _pathOfMusic, HashSet<MusicMood> _moods)
        {

        }

        public Music(int _musicDuration, List<Rhythm> _rhythms, int _currentRhythmIndex, string _pathOfMusic, HashSet<MusicGenre> _genre)
        {

        }

        public Music(int _musicDuration, List<Rhythm> _rhythms, int _currentRhythmIndex, string _pathOfMusic, HashSet<MusicInstrument> _instruments)
        {

        }

        public Music(int _musicDuration, List<Rhythm> _rhythms, int _currentRhythmIndex, string _pathOfMusic, HashSet<MusicDance> _dances)
        {

        }

        public Music(int _musicDuration, List<Rhythm> _rhythms, int _currentRhythmIndex, string _pathOfMusic, HashSet<MusicMood> _moods,
                     HashSet<MusicGenre> _genre, HashSet<MusicInstrument> _instruments, HashSet<MusicDance> _dances)
        {

        }

        public HashSet<MusicMood> Moods { get; set; }
        public HashSet<MusicDance> Dances { get; set; }
        public HashSet<MusicGenre> Genres { get; set; }
        public HashSet<MusicInstrument> Instruments { get; set; }

        public List<Rhythm> Rhythms { get; set; }

        public int CurrentRhythmIndex { get; set; }

        public bool RepeatMusic { get; set; }

        public string MusicLocation { get; set; }

        public int MusicDuration { get; set; }

        public void SwitchRhythm()
        {

        }

        public void SetNextRhythm()
        {

        }

        public void SetPreviousRhythm()
        {

        }

        public void PlayMusic()
        {

        }

        public void StopMusic()
        {

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
