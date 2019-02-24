using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;


namespace Primary_Queen
{
    public class PrimaryMovingStrategyIntelligence
    {
        private Dictionary<float,float> multiplesIntelligence = new Dictionary<float, float>();
        private Dictionary<byte, float> permutationLengthIntelligence = new Dictionary<byte, float>();
        private Dictionary<string, float> movingStrategyIntelligence = new Dictionary<string, float>();
        private Dictionary<Rhythm, float> rhythmIntelligence = new Dictionary<Rhythm, float>();
        private Dictionary<Music, float> musicIntelligence = new Dictionary<Music, float>();


        public PrimaryMovingStrategyIntelligence()
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<string> movingStrategys)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<Rhythm> rhythms, List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<string> movingStrategys, List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<string> movingStrategys, List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,
                                                 List<string> movingStrategys)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, 
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, 
                                                 List<string> movingStrategys)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths,
                                                  List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<string> movingStrategys, 
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<string> movingStrategys, List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,List<string> movingStrategys, 
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,
                                                 List<string> movingStrategys, List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<string> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples,  List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths,                                                 
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths,
                                                 List<string> movingStrategys)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<byte> permutationLengths,
                                                 List<string> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<string> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths,
                                                 List<Rhythm> rhythms, List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths,
                                                 List<string> movingStrategys, List<Music> musicList)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths,
                                                 List<string> movingStrategys, List<Rhythm> rhythms)
        {

        }

        public PrimaryMovingStrategyIntelligence(List<float> multiples, List<byte> permutationLengths, 
                                                 List<string> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        // Multiple Intelligence
        public float this[float multiple]
        {
            get
            { return multiplesIntelligence[multiple]; }

            set
            {
                multiplesIntelligence[multiple] = value;
            }
        }

        // Moving strategy length Intelligence
        public float this[byte movingStrategyLength]
        {
            get
            { return permutationLengthIntelligence[movingStrategyLength]; }

            set
            {
                permutationLengthIntelligence[movingStrategyLength] = value;
            }
        }

        // Moving strategy Intelligence
        public float this[string movingStrategy]
        {
            get
            { return movingStrategyIntelligence[movingStrategy]; }

            set
            {
                movingStrategyIntelligence[movingStrategy] = value;
            }
        }

        // Rhythm Intelligence
        public float this[Rhythm rhythm]
        {
            get
            { return rhythmIntelligence[rhythm]; }

            set
            {
                rhythmIntelligence[rhythm] = value;
            }
        }

        // Music Intelligence
        public float this[Music music]
        {
            get
            { return musicIntelligence[music]; }

            set
            {
                musicIntelligence[music] = value;
            }
        }


        public void IncreaseIntelligence(Music musicKey, float amount)
        {

        }

        public void IncreaseIntelligence(Rhythm rhythmKey, float amount)
        {

        }

        public void IncreaseIntelligence(string movingStrategyKey, float amount)
        {

        }

        public void IncreaseIntelligence(float multipleKey, float amount)
        {

        }

        public void IncreaseIntelligence(byte movingStrategyLengthKey, float amount)
        {

        }

        public void DecreaseIntelligence(Music musicKey, float amount)
        {

        }

        public void DecreaseIntelligence(Rhythm rhythmKey, float amount)
        {

        }

        public void DecreaseIntelligence(string movingStrategyKey, float amount)
        {

        }

        public void DecreaseIntelligence(float multipleKey, float amount)
        {

        }

        public void DecreaseIntelligence(byte movingStrategyLengthKey, float amount)
        {

        }

        public bool IsPartialSmart(float multiple, PrimaryMovingStrategyIntelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(Music music, PrimaryMovingStrategyIntelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(Rhythm rhythm, PrimaryMovingStrategyIntelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(string movingStrategy, PrimaryMovingStrategyIntelligence intelligence)
        {
            return true;
        }    

        public bool IsPartialSmart(byte permutationLength, PrimaryMovingStrategyIntelligence intelligence)
        {
            return true;
        }

        public Dictionary<Key, float> GetPartialIntelligence(byte permutationLength)
        {
            return new Dictionary<Key, float>();
        }

        public Dictionary<Key, float> GetPartialIntelligence(float multiple)
        {
            return new Dictionary<Key, float>();
        }

        public Dictionary<Key, float> GetPartialIntelligence(string movingStrategy)
        {
            return new Dictionary<Key, float>();
        }

        public Dictionary<Key, float> GetPartialIntelligence(Rhythm rhythm)
        {
            return new Dictionary<Key, float>();
        }

        public Dictionary<Key, float> GetPartialIntelligence(Music music)
        {
            return new Dictionary<Key, float>();
        }

        public  class Key
        {
            private float multiple;
            private  String movingStrategy;


            public Key()
            {

            }

            public Key(float multiple, String movingStrategy)
            {
                this.multiple = multiple;
                this.movingStrategy = movingStrategy;
            }

            public float Multiple
            {
                get; set;
            }

            public string MovingStrategy
            {
                get; set;
            }


        }
    }
}
