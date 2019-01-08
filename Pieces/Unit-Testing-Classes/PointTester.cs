using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pieces.Unit_Testing_Classes
{
    // All methods work as expected.
    // I didn't test using the Point class default constructor.
    public class PointTester
    {

        protected internal Point pointZero;
        protected internal Point pointOne;
        protected internal Point pointTwo;

        protected internal Point pointZZ;
        protected internal Point pointOO;
        protected internal Point pointTT;

        public PointTester()
        {
            List<float> point0 = new List<float> { 10.0f };
            List<float> point1 = new List<float> { 0.0f, 50.0f };
            List<float> point2 = new List<float> { 0.0f, 2.5f ,5.0f};

            List<float> point00 = new List<float> { 18.0f };
            List<float> point11 = new List<float> { 0.0f, -5.0f };
            List<float> point22 = new List<float> { 10.0f, 2.5f, 5.0f };


            pointZero = new Point(point0, false);
            pointOne = new Point(point1, false);
            pointTwo = new Point(point2, true);

            pointZZ = new Point(point00, false);
            pointOO = new Point(point11, false);
            pointTT = new Point(point22, true);



        }

        public PointTester(Point pointZero, Point pointOne, Point pointTwo)
        {
            if (pointZero.getDimension() == pointOne.getDimension()
               && pointZero.getDimension() == pointTwo.getDimension())
            {
                this.pointZero = pointZero;
                this.pointOne = pointOne;
                this.pointTwo = pointTwo;

                List<float> point00 = new List<float> { 12.0f };
                List<float> point11 = new List<float> { 3.0f, -25.0f };
                List<float> point22 = new List<float> { 11.0f, 2.5f, 15.0f };


                pointZZ = new Point(point00, false);
                pointOO = new Point(point11, false);
                pointTT = new Point(point22, true);

            }

            else
                Console.WriteLine("Make sure you enter points of same dimension!");
        }

        // Status - Checked , Result - working.
        // Test display method of a point.
        public void checkPoint()
        {
            Console.Write("Point zero\t");
            Console.Write("Point one\t");
            Console.WriteLine("Point two\t");
            


            pointZero.display();
            Console.Write("\t\t");

            pointOne.display();
            Console.Write(" \t");

            pointTwo.display();
            Console.WriteLine("\n");
        }

        // Status - Checked , Result - working.
        // Test compareTo for all 3 types of dimensional points.
        public void showComparedPoints()
        {
            testOneDPoints();
            testTwoDPoints();
            testThreeDPoints();
        }

        // Status - Checked , Result - working.
        // Test compareTo and display for the one dimensional points.
        public void testOneDPoints()
        {
            Console.WriteLine("----------------Comparing pointZero and pointZZ-----------------");
            Console.Write("\nCompare ");
            pointZero.display();

            Console.Write(" with ");
            pointZZ.display();

            Console.Write(" we get that point ");
            if (pointZero.compareTo(pointZZ) == -1)
            {
                pointZero.display();
                Console.Write(" is less than ");
                pointZZ.display();
            }

            else if (pointZero.compareTo(pointZZ) == 1)
            {
                pointZero.display();
                Console.Write(" is greater than ");
                pointZZ.display();
            }


            else if (pointZero.compareTo(pointZZ) == 0)
            {
                pointZero.display();
                Console.Write(" is equals to ");
                pointZZ.display();
            }
            else
                Console.WriteLine("they can't be compared because they on of different dimensions.");

            Console.WriteLine();
        }

        // Status - Checked , Result - working.
        // Test compareTo and display for the two dimensional points.
        public void testTwoDPoints()
        {
            Console.WriteLine("----------------Comparing pointTwo and pointTT-----------------");
            Console.Write("\nCompare ");
            pointOne.display();

            Console.Write(" with ");
            pointOO.display();

            Console.Write(" we get that point ");
            if (pointOne.compareTo(pointOO) == -1)
            {
                pointOne.display();
                Console.Write(" is less than ");
                pointOO.display();
            }

            else if (pointOne.compareTo(pointOO) == 1)
            {
                pointOne.display();
                Console.Write(" is greater than ");
                pointOO.display();
            }


            else if (pointOne.compareTo(pointOO) == 0)
            {
                pointOne.display();
                Console.Write(" is equals to ");
                pointOO.display();
            }
            else
                Console.WriteLine("they can't be compared because they on of different dimensions.");

            Console.WriteLine();

        }

        // Status - Checked , Result - working.
        // Test compareTo and display for the three dimensional points.
        public void testThreeDPoints()
        {
            Console.WriteLine("----------------Comparing pointTwo and pointTT-----------------");
            Console.Write("\nCompare ");
            pointTwo.display();

            Console.Write(" with ");
            pointTT.display();

            Console.Write(" we get that point ");
            if (pointTwo.compareTo(pointTT) == -1)
            {
                pointTwo.display();
                Console.Write(" is less than ");
                pointTT.display();
            }

            else if (pointTwo.compareTo(pointTT) == 1)
            {
                pointTwo.display();
                Console.Write(" is greater than ");
                pointTT.display();
            }


            else if (pointTwo.compareTo(pointTT) == 0)
            {
                pointTwo.display();
                Console.Write(" is equals to ");
                pointTT.display();
            }
            else
                Console.WriteLine("they can't be compared because they on of different dimensions.");

            Console.WriteLine();

        }

        // Status - Checked , Result - working.
        // Retrieving and updating a point.
        public void testUpdate()
        {
            checkPoint();
            Console.WriteLine();

            Console.WriteLine("\n\n----Point[---getAxisAt(index)--&--setAxistAt(index)---]--");
            Console.Write("\t\tThe list of pointZero -> ");
            pointZero.display();
            Console.Write("\nUpdate pointZero at '1' from " + pointZero.getAxisAt(1) + " to ");
            pointZero.setAxisAt(1, 111.0f);
            Console.WriteLine(pointZero.getAxisAt(1) + ".");

            Console.WriteLine();
            Console.Write("\t\tThe list of pointOne -> ");
            pointOne.display();
            Console.Write("\nUpdate pointOne at '2' from " + pointOne.getAxisAt(2) + " to ");
            pointOne.setAxisAt(2, 798.0f);
            Console.WriteLine(pointOne.getAxisAt(2) + ".");

            Console.WriteLine();
            Console.Write("\t\tThe list of pointTwo -> ");

            pointTwo.display();
            Console.Write("\nUpdate pointTwo at '3' from " + pointTwo.getAxisAt(3) + " to ");
            pointTwo.setAxisAt(3, 1.0f);
            Console.WriteLine(pointTwo.getAxisAt(3) + ".");

            

            Console.WriteLine();

            checkPoint();

            Console.WriteLine();

            Console.WriteLine("\n\n----Point[---increaseAxisAt(index,amount)--&--decreaseAxistAt(index,amount)---]--");

            Console.Write("\n\nIncrease pointZero at '0' from " + pointZero.getAxisAt(0) + " to ");
            pointZero.increaseAxisAt(0, 100.0f);
            Console.WriteLine(pointZero.getAxisAt(0) + " by amount of 100.0f.");

            Console.Write("\nIncrease pointOne at '1' from " + pointOne.getAxisAt(1) + " to ");
            pointOne.increaseAxisAt(1, 200.0f);
            Console.WriteLine(pointOne.getAxisAt(1) + " by amount of 200.0f.");

            Console.Write("\nIncrease pointTwo at '1' from " + pointTwo.getAxisAt(1) + " to ");
            pointTwo.increaseAxisAt(1, 100.0f);
            Console.WriteLine(pointTwo.getAxisAt(1) + " by amount of 100.0f.");

            Console.WriteLine();
            checkPoint();
            Console.WriteLine();

            Console.Write("\nDecrease pointZero at '0' from " + pointZero.getAxisAt(0) + " to ");
            pointZero.decreaseAxisAt(0, 10.0f);
            Console.WriteLine(pointZero.getAxisAt(0) + " by amount of 10.0f.");

            
            Console.Write("\nDecrease pointOne at '1' from " + pointOne.getAxisAt(1) + " to ");
            pointOne.decreaseAxisAt(1, 200.0f);
            Console.WriteLine(pointOne.getAxisAt(1) + " by amount of 200.0f.");

            
            Console.Write("\nDecrease pointTwo at '1' from " + pointTwo.getAxisAt(1) + " to ");
            pointTwo.decreaseAxisAt(1, 50.0f);
            Console.WriteLine(pointTwo.getAxisAt(1) + " by amount of 50.0f.");
            
            checkPoint();

        }

    }
}
