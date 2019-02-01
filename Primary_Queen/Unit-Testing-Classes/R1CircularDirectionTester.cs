using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Queen.Unit_Testing_Classes
{
    public class R1CircularDirectionTester
    {
        protected internal R1CircularDirection r1Direction;
        protected internal R1CircularDirection r2Direction;

        public R1CircularDirectionTester()
        {
            r1Direction = new R1CircularDirection();
            List<bool> canShoot = new List<bool>();

            float directionLength = 5;
            float directionDivisor = 0.5f;
            int direction = 1;



            for (int i = 0; i < directionLength / directionDivisor; i++)
                if (i % 2 == 0)
                    canShoot.Add(true);
                else
                    canShoot.Add(false);


            r2Direction = new R1CircularDirection(new R1Point(0), direction, directionLength, directionDivisor, 1000);
        }

        public R1CircularDirectionTester(R1CircularDirection r1Direction, R1CircularDirection r2Direction)
        {
            this.r1Direction = r1Direction;
            this.r2Direction = r2Direction;
        }

        public void PrintCanShoot()
        {
           
        }
    }
}
