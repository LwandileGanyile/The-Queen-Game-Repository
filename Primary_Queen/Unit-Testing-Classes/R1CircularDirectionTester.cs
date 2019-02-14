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
        protected internal R1CircularDirection r3Direction;
        protected internal R1CircularDirection r4Direction;

        public R1CircularDirectionTester()
        {
            r1Direction = new R1CircularDirection();
            List<bool> canShoot = new List<bool>();

            

            float directionLength = 5;
            float directionDivisor = 0.5f;
            int direction = 1;

            int numberOfElements = (int)(directionLength / directionDivisor);



            for (int i = 0; i < numberOfElements; i++)
                if (i % 2 == 0)
                    canShoot.Add(true);
                else
                    canShoot.Add(false);



            Dictionary<int, int> duration = new Dictionary<int, int>();
            

            for (int i = 0; i < numberOfElements; i++)
            {
                duration.Add(i,1000/numberOfElements);
            }

            r2Direction = new R1CircularDirection(new R1Point(0), direction, directionDivisor, duration);


            r3Direction = new R1CircularDirection(new R1Point(-1), direction, directionLength, directionDivisor, duration);

            r4Direction = new R1CircularDirection(new R1Point(-1), direction, directionLength, directionDivisor, duration, 3);

            /*CheckIsDirectionValid(-1);
            CheckIsDirectionValid(0);
            CheckIsDirectionValid(1);
            CheckIsDirectionValid(2);
            CheckIsDirectionValid(3);

            CheckIsDimensionCorrect();
            CheckIsPointCorrect();
            CheckReflectAboutX();
            CheckRotateAroundX();
            CheckReflectEqualX();
            CheckRotateAroundEqualX();
            CheckTranslate();*/
            CheckCompareTo();
        }

        public R1CircularDirectionTester(R1CircularDirection r1Direction, R1CircularDirection r2Direction, R1CircularDirection r3Direction, R1CircularDirection r4Direction)
        {
            this.r1Direction = r1Direction;
            this.r2Direction = r2Direction;
            this.r3Direction = r3Direction;
            this.r4Direction = r4Direction;
        }

        // Checks whether or not the direction is valid.
        public void CheckIsDirectionValid(int direction)
        {
            Console.WriteLine("\n*********************Checking direction "+direction+" *******************************");
            Console.WriteLine("Is the direction of list1 valid? : " + r1Direction.IsDirectionValid(direction));
            Console.WriteLine("Is the direction of list2 valid? : " + r2Direction.IsDirectionValid(direction));
            Console.WriteLine("Is the direction of list3 valid? : " + r3Direction.IsDirectionValid(direction));
            Console.WriteLine("Is the direction of list4 valid? : " + r4Direction.IsDirectionValid(direction));
            Console.WriteLine();
        }

        // Checks whether or not the direction is valid.
        public void CheckIsDimensionCorrect()
        {
            Console.WriteLine("\n***************Checking the IsDirectionDimensionCorrect method *****************");
            Console.WriteLine("Is the direction dimension of list1 correct? : " + r1Direction.IsDirectionDimensionCorrect());
            Console.WriteLine("Is the direction dimension of list2 correct? : " + r2Direction.IsDirectionDimensionCorrect());
            Console.WriteLine("Is the direction dimension of list3 correct? : " + r3Direction.IsDirectionDimensionCorrect());
            Console.WriteLine("Is the direction dimension of list4 correct? : " + r4Direction.IsDirectionDimensionCorrect());
            Console.WriteLine();
        }

        // Checks whether or not the direction is valid.
        public void CheckIsPointCorrect()
        {
            Console.WriteLine("\n***************Checking the IsPointDimensionCorrect method *****************");
            Console.WriteLine("Is the point dimension of list1 correct? : " + r1Direction.IsPointDimensionCorrect());
            Console.WriteLine("Is the point dimension of list2 correct? : " + r2Direction.IsPointDimensionCorrect());
            Console.WriteLine("Is the point dimension of list3 correct? : " + r3Direction.IsPointDimensionCorrect());
            Console.WriteLine("Is the point dimension of list4 correct? : " + r4Direction.IsPointDimensionCorrect());
            Console.WriteLine();
        }

        // Checks whether or not the one can reflect about axis.
        public void CheckReflectAboutX()
        {
           
            Console.WriteLine("\n***************Checking the ReflectAboutAxis(-1) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n"+
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r1Direction.ReflectAboutAxis(-1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r2Direction.ReflectAboutAxis(-1).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r3Direction.ReflectAboutAxis(-1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r4Direction.ReflectAboutAxis(-1).ToString());

            Console.WriteLine("\n***************Checking the ReflectAboutAxis(0) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("After calling ReflectAboutAxis(0) on : \n" +
            r1Direction.ReflectAboutAxis(0).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r2Direction.ReflectAboutAxis(0).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r3Direction.ReflectAboutAxis(0).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r4Direction.ReflectAboutAxis(0).ToString());

            Console.WriteLine();

            Console.WriteLine("\n***************Checking the ReflectAboutAxis(1) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n"+
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r1Direction.ReflectAboutAxis(1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r2Direction.ToString());
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r2Direction.ReflectAboutAxis(1).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r3Direction.ReflectAboutAxis(1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r4Direction.ReflectAboutAxis(1).ToString());


            Console.WriteLine();
        }

        // Checks whether or not the one can rotate about axis.
        public void CheckRotateAroundEqualX()
        {

            Console.WriteLine("\n***************Checking the RotateAboutAxis((new List<int> { +-1,+-2}, index) method *****************");

            Console.WriteLine("\nBefore calling RotateAboutAxis((new List<int> { 1,2}, 2) on: \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAboutAxis((new List<int> { 1,2}, 2) on : \n" +
            r1Direction.RotateAroundEqualAxis(new List<int> { 1, 2 }, 2).ToString());


            Console.WriteLine("\nBefore calling RotateAboutAxis((new List<int> { 1,2}, 3) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAboutAxis((new List<int> { -1,2}, 3) on : \n" +
            r2Direction.RotateAroundEqualAxis(new List<int> { -1, 2 }, 3).ToString());

            Console.WriteLine("\nBefore calling RotateAboutAxis((new List<int> { 1,2}, 4) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAboutAxis((new List<int> { 1,-2}, 4) on : \n" +
            r3Direction.RotateAroundEqualAxis(new List<int> { 1, -2 }, 4).ToString());


            Console.WriteLine("\nBefore calling RotateAboutAxis((new List<int> { 1,2}, 5) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAboutAxis((new List<int> { -1,-2}, 5) on : \n" +
            r4Direction.RotateAroundEqualAxis(new List<int> { -1, -2 }, 5).ToString());

            
        }


        // Checks whether or not the one can reflect about axis.
        public void CheckReflectEqualX()
        {

            Console.WriteLine("\n***************Checking the ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(new List<int> { 1,-2}, 2) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(new List<int> { 1,-2}, 2) on : \n" +
            r1Direction.ReflectAroundEqualAxis(new List<int> { 1,-2}, 2).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(new List<int> { 1, 2 }, 2) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(new List<int> { 1, 2 }, 2) on : \n" +
            r2Direction.ReflectAroundEqualAxis(new List<int> { 1, 2 }, 2).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(new List<int> { -1, -2 }, 3) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(new List<int> { -1, -2 }, 3) on : \n" +
            r3Direction.ReflectAroundEqualAxis(new List<int> { -1, -2 }, 3).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(new List<int> { -1, 2 }, 3) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(new List<int> { -1, 2 }, 3) on : \n" +
            r4Direction.ReflectAroundEqualAxis(new List<int> { -1, 2 }, 2).ToString());

            Console.WriteLine();
            Console.WriteLine("\n***************Checking the ReflectAboutAxis(0) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("After calling ReflectAboutAxis(0) on : \n" +
            r1Direction.ReflectAboutAxis(0).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r2Direction.ReflectAboutAxis(0).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r3Direction.ReflectAboutAxis(0).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r4Direction.ReflectAboutAxis(0).ToString());

            Console.WriteLine();

            Console.WriteLine("\n***************Checking the ReflectAboutAxis(-1) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r1Direction.ReflectAboutAxis(-1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r2Direction.ToString());
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r2Direction.ReflectAboutAxis(-1).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r3Direction.ReflectAboutAxis(-1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r4Direction.ReflectAboutAxis(-1).ToString());


            Console.WriteLine();

            Console.WriteLine("\n***************Checking the ReflectAboutAxis(0) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("After calling ReflectAboutAxis(0) on : \n" +
            r1Direction.ReflectAboutAxis(0).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r2Direction.ReflectAboutAxis(0).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r3Direction.ReflectAboutAxis(0).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(0) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(0) on : \n" +
            r4Direction.ReflectAboutAxis(0).ToString());

            Console.WriteLine();

            Console.WriteLine("\n***************Checking the ReflectAboutAxis(1) method *****************");

            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r1Direction.ReflectAboutAxis(1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r2Direction.ToString());
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r2Direction.ReflectAboutAxis(1).ToString());

            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r3Direction.ReflectAboutAxis(1).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(1) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(1) on : \n" +
            r4Direction.ReflectAboutAxis(1).ToString());


            Console.WriteLine();
        }

        // Checks whether or not the one can rotate about axis.
        public void CheckRotateAroundX()
        {

            Console.WriteLine("\nBefore calling ReflectAboutAxis(-1) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(-1) on : \n" +
            r3Direction.RotateAroundAxis(-1,4).ToString());


            Console.WriteLine("\nBefore calling ReflectAboutAxis(2) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling ReflectAboutAxis(2) on : \n" +
            r4Direction.RotateAroundAxis(2,3).ToString());


            Console.WriteLine();

            Console.WriteLine("\n***************Checking the RotateAroundAxis(axis,times) method *****************");

            Console.WriteLine("\nBefore calling RotateAroundAxis(1,1) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("After calling ReflectAboutAxis(1,1) on : \n" +
            r1Direction.RotateAroundAxis(1,1).ToString());


            Console.WriteLine("\nBefore calling RotateAroundAxis(1,2) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAroundAxis(1,2) on : \n" +
            r2Direction.RotateAroundAxis(1,2).ToString());

            Console.WriteLine("\nBefore calling RotateAroundAxis(2,1) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAroundAxis(2,1) on : \n" +
            r3Direction.RotateAroundAxis(2,1).ToString());


            Console.WriteLine("\nBefore calling RotateAroundAxis(2,2) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling RotateAroundAxis(2,2) on : \n" +
            r4Direction.RotateAroundAxis(2,2).ToString());

            Console.WriteLine();

        }

        // Checks the translate method.
        public void CheckTranslate()
        {

            
            Console.WriteLine("\n***************Checking the translate(direction,10) method *****************");

            //////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nBefore calling translate(-1,10) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,10) on : \n" +
            r1Direction.translate(-1,10).ToString());


            Console.WriteLine("\nBefore calling translate(0,10) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,10) on : \n" +
            r1Direction.translate(0, 10).ToString());

            Console.WriteLine("\nBefore calling translate(1,10) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,10) on : \n" +
            r1Direction.translate(1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(2,10) on : \n" +
             r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,10) on : \n" +
            r1Direction.translate(2, 10).ToString());

            Console.WriteLine("\nBefore calling translate(3,10) on : \n" +
             r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,10) on : \n" +
            r1Direction.translate(3, 10).ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nBefore calling translate(-1,10) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,10) on : \n" +
            r2Direction.translate(-1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(0,10) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,10) on : \n" +
            r2Direction.translate(0, 10).ToString());

            Console.WriteLine("\nBefore calling translate(1,10) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,10) on : \n" +
            r2Direction.translate(1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(2,10) on : \n" +
             r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,10) on : \n" +
            r1Direction.translate(2, 10).ToString());

            Console.WriteLine("\nBefore calling translate(3,10) on : \n" +
             r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,10) on : \n" +
            r2Direction.translate(3, 10).ToString());

            ///////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nBefore calling translate(-1,10) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,10) on : \n" +
            r3Direction.translate(-1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(0,10) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,10) on : \n" +
            r3Direction.translate(0, 10).ToString());

            Console.WriteLine("\nBefore calling translate(1,10) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,10) on : \n" +
            r3Direction.translate(1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(2,10) on : \n" +
             r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,10) on : \n" +
            r3Direction.translate(2, 10).ToString());

            Console.WriteLine("\nBefore calling translate(3,10) on : \n" +
             r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,10) on : \n" +
            r3Direction.translate(3, 10).ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nBefore calling translate(-1,10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,10) on : \n" +
            r4Direction.translate(-1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(0,10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,10) on : \n" +
            r4Direction.translate(0, 10).ToString());

            Console.WriteLine("\nBefore calling translate(1,10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,10) on : \n" +
            r4Direction.translate(1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(2,10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,10) on : \n" +
            r4Direction.translate(2, 10).ToString());

            Console.WriteLine("\nBefore calling translate(3,10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,10) on : \n" +
            r4Direction.translate(3, 10).ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////



            Console.WriteLine("\n***************Checking the translate(direction,-10) method *****************");

            //////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nBefore calling translate(-1,-10) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,-10) on : \n" +
            r1Direction.translate(-1, -10).ToString());


            Console.WriteLine("\nBefore calling translate(0,-10) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,-10) on : \n" +
            r1Direction.translate(0, -10).ToString());

            Console.WriteLine("\nBefore calling translate(1,-10) on : \n" +
            r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,-10) on : \n" +
            r1Direction.translate(1, -10).ToString());


            Console.WriteLine("\nBefore calling translate(2,-10) on : \n" +
             r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,-10) on : \n" +
            r1Direction.translate(2, 10).ToString());

            Console.WriteLine("\nBefore calling translate(3,-10) on : \n" +
             r1Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,-10) on : \n" +
            r1Direction.translate(3, -10).ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nBefore calling translate(-1,-10) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,-10) on : \n" +
            r2Direction.translate(-1, -10).ToString());


            Console.WriteLine("\nBefore calling translate(0,-10) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,-10) on : \n" +
            r2Direction.translate(0, -10).ToString());

            Console.WriteLine("\nBefore calling translate(1,-10) on : \n" +
            r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,-10) on : \n" +
            r2Direction.translate(1, -10).ToString());


            Console.WriteLine("\nBefore calling translate(2,-10) on : \n" +
             r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,-10) on : \n" +
            r1Direction.translate(2, -10).ToString());

            Console.WriteLine("\nBefore calling translate(3,-10) on : \n" +
             r2Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,-10) on : \n" +
            r2Direction.translate(3, -10).ToString());

            ///////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nBefore calling translate(-1,-10) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,-10) on : \n" +
            r3Direction.translate(-1, -10).ToString());


            Console.WriteLine("\nBefore calling translate(0,-10) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,-10) on : \n" +
            r3Direction.translate(0, -10).ToString());

            Console.WriteLine("\nBefore calling translate(1,-10) on : \n" +
            r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,-10) on : \n" +
            r3Direction.translate(1, -10).ToString());


            Console.WriteLine("\nBefore calling translate(2,-10) on : \n" +
             r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,-10) on : \n" +
            r3Direction.translate(2, -10).ToString());

            Console.WriteLine("\nBefore calling translate(3,-10) on : \n" +
             r3Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,-10) on : \n" +
            r3Direction.translate(3, -10).ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nBefore calling translate(-1,-10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(-1,-10) on : \n" +
            r4Direction.translate(-1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(0,-10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(0,-10) on : \n" +
            r4Direction.translate(0, 10).ToString());

            Console.WriteLine("\nBefore calling translate(1,-10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(1,-10) on : \n" +
            r4Direction.translate(1, 10).ToString());


            Console.WriteLine("\nBefore calling translate(2,-10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(2,-10) on : \n" +
            r4Direction.translate(2, 10).ToString());

            Console.WriteLine("\nBefore calling translate(3,-10) on : \n" +
            r4Direction.ToString());
            Console.WriteLine();
            Console.WriteLine("\nAfter calling translate(3,-10) on : \n" +
            r4Direction.translate(3, -10).ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine();
        }

        public void CheckCompareTo()
        {
            Dictionary<int, int> duration = new Dictionary<int, int>();

            duration.Add(0, 1500);
            duration.Add(1, 3000);
            duration.Add(2, 4500);
            duration.Add(3, 6000);
            duration.Add(4, 1500);
            duration.Add(5, 3000);
            duration.Add(6, 4500);
            duration.Add(7, 6000);
            duration.Add(8, 1500);
            duration.Add(9, 3000);
            duration.Add(10, 4500);
            duration.Add(11, 6000);

            R1CircularDirection direction1 = new R1CircularDirection(new R1Point(5),1,5,duration);
            R1CircularDirection direction2 = new R1CircularDirection(new R1Point(-5),1,5,duration);
            R1CircularDirection direction3 = new R1CircularDirection(new R1Point(10), 2, 2.5f, duration);
            R1CircularDirection direction4 = new R1CircularDirection(new R1Point(-10), 2, 3.5f, duration);

            R1CircularDirection direction5 = new R1CircularDirection(new R1Point(5), 1, 5, duration);
            R1CircularDirection direction6 = new R1CircularDirection(new R1Point(-5), 1, 5, duration);
            R1CircularDirection direction7 = new R1CircularDirection(new R1Point(10), 2, 2.5f, duration);
            R1CircularDirection direction8 = new R1CircularDirection(new R1Point(-10), 2, 3.5f, duration);

            R1CircularDirection direction11 = new R1CircularDirection(new R1Point(5),1,10,2,duration);
            R1CircularDirection direction22 = new R1CircularDirection(new R1Point(-5), 1,100, 20, duration);
            R1CircularDirection direction33 = new R1CircularDirection(new R1Point(10), 2, 15, 2.5f, duration);
            R1CircularDirection direction44 = new R1CircularDirection(new R1Point(-10), 2, 28,3.5f, duration);

            R1CircularDirection direction55 = new R1CircularDirection(new R1Point(5), 1, 10, 2, duration);
            R1CircularDirection direction66 = new R1CircularDirection(new R1Point(-5), 1, 100, 20, duration);
            R1CircularDirection direction77 = new R1CircularDirection(new R1Point(10), 2, 15, 2.5f, duration);
            R1CircularDirection direction88 = new R1CircularDirection(new R1Point(-10), 2, 28, 3.5f, duration);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n"+ r1Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction1.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r1Direction.CompareTo(direction1) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString()+ " \n\t\t---is less than ---direction : \n\n" + direction1.ToString());
            else if (r1Direction.CompareTo(direction1) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction1.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction1.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + r1Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + r2Direction.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r1Direction.CompareTo(r2Direction) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is less than ---direction : \n\n" + r2Direction.ToString());
            else if (r1Direction.CompareTo(r2Direction) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + r2Direction.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + r2Direction.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + r1Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + r3Direction.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r1Direction.CompareTo(r3Direction) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is less than ---direction : \n\n" + r3Direction.ToString());
            else if (r1Direction.CompareTo(r3Direction) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + r3Direction.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + r3Direction.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + r1Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + r4Direction.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r1Direction.CompareTo(r4Direction) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is less than ---direction : \n\n" + r4Direction.ToString());
            else if (r1Direction.CompareTo(r4Direction) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + r4Direction.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r1Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + r4Direction.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + r2Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + r3Direction.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r2Direction.CompareTo(r3Direction) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r2Direction.ToString() + " \n\t\t---is less than ---direction : \n\n" + r3Direction.ToString());
            else if (r2Direction.CompareTo(r3Direction) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r2Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + r3Direction.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r2Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + r3Direction.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + r2Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + r4Direction.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r2Direction.CompareTo(r4Direction) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r2Direction.ToString() + " \n\t\t---is less than ---direction : \n\n" + r4Direction.ToString());
            else if (r2Direction.CompareTo(r4Direction) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r2Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + r4Direction.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r2Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + r4Direction.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + r3Direction.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + r4Direction.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (r3Direction.CompareTo(r4Direction) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r3Direction.ToString() + " \n\t\t---is less than ---direction : \n\n" + r4Direction.ToString());
            else if (r3Direction.CompareTo(r4Direction) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + r3Direction.ToString() + " \n\t\t---is greater ---than direction : \n\n" + r4Direction.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + r3Direction.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + r4Direction.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*************************************************************************************************************/

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction22.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction22) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction22.ToString());
            else if (direction11.CompareTo(direction1) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction22.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction22.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction33.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction33) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction33.ToString());
            else if (direction11.CompareTo(direction1) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction33.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction33.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction44.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction44) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction44.ToString());
            else if (direction11.CompareTo(direction44) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction44.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction44.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction55.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction55) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction55.ToString());
            else if (direction11.CompareTo(direction55) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction55.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction55.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction66.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction66) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction66.ToString());
            else if (direction11.CompareTo(direction66) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction66.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction66.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction77.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction77) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction77.ToString());
            else if (direction11.CompareTo(direction77) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction77.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction77.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction88.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction11.CompareTo(direction88) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction88.ToString());
            else if (direction11.CompareTo(direction88) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction88.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction11.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction88.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction22.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction33.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction22.CompareTo(direction33) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction33.ToString());
            else if (direction22.CompareTo(direction33) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction33.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction33.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction22.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction44.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction22.CompareTo(direction44) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction44.ToString());
            else if (direction22.CompareTo(direction44) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction44.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction44.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction11.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction55.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction22.CompareTo(direction55) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction55.ToString());
            else if (direction22.CompareTo(direction55) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction55.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction55.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction22.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction66.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction22.CompareTo(direction66) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction66.ToString());
            else if (direction22.CompareTo(direction66) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction66.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction66.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction22.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction77.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction22.CompareTo(direction77) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction77.ToString());
            else if (direction22.CompareTo(direction77) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction77.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction77.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction22.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction88.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction22.CompareTo(direction88) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction88.ToString());
            else if (direction22.CompareTo(direction88) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction88.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction22.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction88.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction33.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction44.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction33.CompareTo(direction44) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction44.ToString());
            else if (direction33.CompareTo(direction44) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction44.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction44.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction33.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction55.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction33.CompareTo(direction55) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction55.ToString());
            else if (direction33.CompareTo(direction55) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction55.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction55.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction22.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction66.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction33.CompareTo(direction66) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction66.ToString());
            else if (direction33.CompareTo(direction66) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction66.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction66.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction33.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction77.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction33.CompareTo(direction77) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction77.ToString());
            else if (direction33.CompareTo(direction77) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction77.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction77.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\t\tComparing direction : \n\n" + direction33.ToString());
            Console.WriteLine("\n\n\n\t\twith direction : \n\n" + direction88.ToString());

            Console.WriteLine("\n************************************************************************************\n");

            if (direction33.CompareTo(direction88) < 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is less than ---direction : \n\n" + direction88.ToString());
            else if (direction33.CompareTo(direction88) > 0)
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is greater ---than direction : \n\n" + direction88.ToString());
            else
                Console.WriteLine("\nWe find that Direction : \n\n" + direction33.ToString() + " \n\t\t---is equals tot-- direction : \n\n" + direction88.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }
    }
}
