using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pieces.Unit_Testing_Classes
{
    public class PointTester
    {

        protected internal Point pointZero;
        protected internal Point pointOne;
        protected internal Point pointTwo;
        protected internal Point pointThree;
        protected internal Point pointFour;

       // protected internal Point point = new Point();

        public PointTester()
        {
            List<float> point0 = new List<float> { 10.0f };
            List<float> point1 = new List<float> { 0.0f, 50.0f };
            List<float> point2 = new List<float> { 0.0f, 2.5f };
            List<float> point3 = new List<float> { 20.0f, 34.0f, 76.5f };
            List<float> point4 = new List<float> { 40.0f, 70.5f, 80.0f, 45.5f };

            pointZero = new Point(point0, false);
            pointOne = new Point(point1, false);
            pointTwo = new Point(point2, true);
            pointThree = new Point(point3, false);
            pointFour = new Point(point4, true);

        }

        public PointTester(Point pointZero, Point pointOne, Point pointTwo, Point pointThree, Point pointFour)
        {
            this.pointZero = pointZero;
            this.pointOne = pointOne;
            this.pointTwo = pointTwo;
            this.pointThree = pointThree;
            this.pointFour = pointFour;
        }

        public void printPoints()
        {
            Console.Write("Point zero -->>\t");
            pointZero.display();

            Console.Write("\nPoint one -->>\t");
            pointOne.display();

            Console.Write("\nPoint two -->>\t");
            pointTwo.display();

            Console.Write("\nPoint three -->>\t");
            pointThree.display();

            Console.Write("\nPoint four -->>\t");
            pointFour.display();
        }

        // Retrieving and updating a point.
        public void testUpdate()
        {
            printPoints();
            Console.WriteLine();
            Console.WriteLine("\n\n----Point[---getAxisAt(index)--&--setAxistAt(index)---]--");
            Console.Write("\t\tThe list of pointZero -> ");
            pointZero.display();
            Console.Write("\nUpdate pointZero at '1' from "+ pointZero.getAxisAt(1)+" to ");
            pointZero.setAxisAt(1,111.0f);
            Console.WriteLine(pointZero.getAxisAt(1)+".");

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
            Console.Write("\t\tThe list of pointThree -> ");

            pointThree.display();
            Console.Write("\nUpdate pointThree at '1' from " + pointThree.getAxisAt(1) + " to ");
            pointThree.setAxisAt(1, 12.0f);
            Console.WriteLine(pointThree.getAxisAt(1) + ".");

            Console.WriteLine();
            Console.Write("\t\tThe list of pointFour -> ");

            pointFour.display();
            Console.Write("\nUpdate pointFour at '4' from " + pointFour.getAxisAt(4) + " to ");
            pointFour.setAxisAt(4, 16.0f);
            Console.WriteLine(pointFour.getAxisAt(4) + ".");

            Console.WriteLine();

            printPoints();

            Console.WriteLine("\n\n----Point[---increaseAxisAt(index,amount)--&--decreaseAxistAt(index,amount)---]--");

            Console.Write("List Zero -->>\t"); pointZero.display();
            Console.WriteLine();
            Console.Write("List One -->>\t"); pointOne.display();
            Console.WriteLine();
            Console.Write("List Two -->>\t"); pointTwo.display();
            Console.WriteLine();
            Console.Write("List Three -->>\t"); pointThree.display();
            Console.WriteLine();
            Console.Write("List Four -->>\t"); pointFour.display();
            Console.WriteLine();

            Console.Write("\n\nIncrease pointZero at '4' from " + pointZero.getAxisAt(4) + " to ");
            pointZero.increaseAxisAt(4, 100.0f);
            Console.WriteLine(pointZero.getAxisAt(4) + " by amount of 100.0f.");

            pointOne.display();
            Console.Write("\nIncrease pointOne at '2' from " + pointOne.getAxisAt(2) + " to ");
            pointOne.increaseAxisAt(2, 200.0f);
            Console.WriteLine(pointOne.getAxisAt(2) + " by amount of 200.0f.");

            pointTwo.display();
            Console.Write("\nIncrease pointTwo at '4' from " + pointTwo.getAxisAt(4) + " to ");
            pointTwo.increaseAxisAt(4, 100.0f);
            Console.WriteLine(pointTwo.getAxisAt(4) + " by amount of 100.0f.");

            pointThree.display();
            Console.Write("\nIncrease pointThree at '5' from " + pointThree.getAxisAt(5) + " to ");
            pointThree.increaseAxisAt(5, 20000.0f);
            Console.WriteLine(pointThree.getAxisAt(5) + " by amount of 20000.0f.");

            pointFour.display();
            Console.Write("\nIncrease pointFour at '0' from " + pointFour.getAxisAt(0) + " to ");
            pointFour.increaseAxisAt(0, 1200.0f);
            Console.WriteLine(pointFour.getAxisAt(0) + " by amount of 1200.0f.");
        }

    }
}
