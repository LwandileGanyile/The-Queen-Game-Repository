using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPattern;

namespace The_Queen
{
    public class King : Agent
    {
        private KingDirection _kingDirection;
        private int currentStep;
        private HashSet<KingStep> steps;


        public King()
        {

        }

        public King(KingDirection _kingDirection, KingStep _kingStep)
        {

        }

        public King(KingDirection _kingDirection, KingStep _kingStep, Rhythm rhythm)
        {

        }

       

        public KingDirection KingDirection { get; }
        public KingStep KingStep { get; set; }

        public override void Resume()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
