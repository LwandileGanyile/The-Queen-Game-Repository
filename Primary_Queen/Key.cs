using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Queen
{
    public class Key
    {
        private float multiple;
        private String movingStrategy;


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
