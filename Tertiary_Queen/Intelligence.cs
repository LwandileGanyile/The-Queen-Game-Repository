using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;
using The_Queen;
using ShootingStrategy;

namespace Tertiary_Queen
{
    public class Intelligence : StrategyIntelligence
    {
        // Each list represents an intelligence based on all 15 different planes in R3.
        private List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes = new List<Dictionary<VectorShootingStrategy, float>>();
        private List<Dictionary<FunctionShootingStrategy, float>> functionShootTypes = new List<Dictionary<FunctionShootingStrategy, float>>();
        private Dictionary<PlaneShootingStrategy, float> planeShootTypes = new Dictionary<PlaneShootingStrategy, float>();

        public List<Dictionary<VectorShootingStrategy, float>> VectorShootType { get; set; }

        public List<Dictionary<FunctionShootingStrategy, float>> FunctionShootType { get; set; }

        public Dictionary<PlaneShootingStrategy, float> PlaneShootType { get; set; }

       

        public Intelligence()
        {

        }

        public Intelligence(List<float> multiples)
        {

        }

        public Intelligence(List<float> multiples, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<Rhythm> rhythms)
        {

        }

        public Intelligence(List<Rhythm> rhythms, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<Music> musicList)
        {

        }

        public Intelligence(List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<Rhythm> rhythms, List<Music> musicList)
        {

        }

        public Intelligence(List<Rhythm> rhythms, List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Music> musicList)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<Music> musicList)
        {

        }

        public Intelligence(List<float> multiples, List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<Rhythm> rhythms)
        {

        }

        public Intelligence(List<float> multiples, List<Rhythm> rhythms, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys,
                                                 List<Music> musicList)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys,
        List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms, 
        List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public Intelligence(List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms,
        List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<Rhythm> rhythms,
        List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public Intelligence(List<float> multiples, List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms,
        List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public Intelligence(List<float> multiples, List<byte> permutationLengths,
                                                 List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms,
                                                 List<Music> musicList)
        {

        }

        public Intelligence(List<float> multiples, List<byte> permutationLengths,
        List<ITertiaryMovingStrategy> movingStrategys, List<Rhythm> rhythms,
        List<Music> musicList, List<Dictionary<VectorShootingStrategy, float>> vectorShootTypes)
        {

        }

        public void IncreaseIntelligence(byte movingStrategyLengthKey, float amount)
        {

        }



        public void DecreaseIntelligence(byte movingStrategyLengthKey, float amount)
        {

        }

        public bool IsPartialSmart(float multiple, Intelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(Music music, Intelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(Rhythm rhythm, Intelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(ITertiaryMovingStrategy movingStrategy, Intelligence intelligence)
        {
            return true;
        }

        public bool IsPartialSmart(byte permutationLength, Intelligence intelligence)
        {
            return true;
        }

        public Dictionary<byte, float> GetPartialIntelligence(byte permutationLength)
        {
            return new Dictionary<byte, float>();
        }

        public void AddVectorShootingStrategy(VectorShootType shootType, VectorShootingStrategy vectorShootingStrategy)
        {

        }

        public void AddPlaneShootingStrategy(PlaneShootType shootType, PlaneShootingStrategy planeShootingStrategy)
        {

        }

        public void AddFunctionShootingStrategy(FunctionShootType shootType, FunctionShootingStrategy planeShootingStrategy)
        {

        }

        public bool IsPartialSmart(VectorShootType vectorShootType)
        {
            return true;
        }

        public bool IsPartialSmart(PlaneShootType planeShootType)
        {
            return true;
        }

        public bool IsPartialSmart(FunctionShootType vectorShootType)
        {
            return true;
        }

        public Dictionary<VectorShootingStrategy, float> GetPartialIntelligence(VectorShootType vectorShootType)
        {
            return null;
        }

        public Dictionary<PlaneShootingStrategy, float> GetPartialIntelligence(PlaneShootType planeShootType)
        {
            return null;
        }

        public Dictionary<FunctionShootingStrategy, float> GetPartialIntelligence(FunctionShootType vectorShootType)
        {
            return null;
        }

    }
}
