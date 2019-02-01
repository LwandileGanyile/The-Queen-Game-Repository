using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Queen.Unit_Testing_Classes
{
    public class R1PointTester
    {
        private List<R1Point> points;

        public R1PointTester()
        {
            points = new List<R1Point> { new R1Point(10.0f),
                                         new R1Point(50.0f),
                                         new R1Point(100.0f),
                                         /*new R1Point(150.0f),
                                         new R1Point(10.0f),
                                         new R1Point(-5.0f),
                                         new R1Point(-10.0f),
                                         new R1Point(-12.0f)*/
                                       };

        }

        public R1PointTester(List<R1Point> points)
        {
            this.points = points;
        }

        public void compareAll() { 


            R1Point point1;
            R1Point point2;

            for (int i = 0; i<points.Count; i++)
            {
                point1 = points[i];
                Console.Write("-------------Comparing ");
                point1.Display();
                Console.WriteLine(" with other points--------------");
               
                for (int j = 0; j<points.Count; j++)
                {
                    point2 = points[j];
                    Console.Write("Compare ");
                    point1.Display();
                    Console.Write(" with ");
                    point2.Display();
                    Console.Write(" we find that ");
                    if (point1.CompareTo(point2) == -1)
                    {
                        point1.Display();
                        Console.Write(" is less than ");
                        point2.Display();
                    }
                    else if (point1.CompareTo(point2) == 1)
                    {
                        point1.Display();
                        Console.Write(" is grater than ");
                        point2.Display();
                    }

                    else if (point1.CompareTo(point2) == 0)
                    {
                        point1.Display();
                        Console.Write(" is equals to ");
                        point2.Display();
                    }

                    else
                    {
                        Console.Write(" The operands on which the comparedTo method/operation is working on has to be the element of R1/1D");
                    }

                    Console.WriteLine(".\n");
                }
            }
          }

        public void increaseAllPoints()
        {
            Console.WriteLine("------------Points before invokng any method--------------------");
            for (int i = 0; i < points.Count;i++)
                    points[i].Display();

            Console.WriteLine("------------Points after invokng the IncreaseXCoordinate with amount = 100--------------------");
            for (int i = 0; i < points.Count; i++)
                points[i].IncreaseXCoordinate(100);
            for (int i = 0; i < points.Count; i++)
                points[i].Display();

        }

        public void decreaseAllPoints()
        {
            Console.WriteLine("------------Points before invokng any method--------------------");
            for (int i = 0; i < points.Count; i++)
                points[i].Display();

            Console.WriteLine("------------Points after invokng the DecreaseXCoordinate with amount = 100--------------------");
            for (int i = 0; i < points.Count; i++)
                points[i].DecreaseXCoordinate(100);
            for (int i = 0; i < points.Count; i++)
                points[i].Display();

        }

        public void setAllPoints()
        {
            Console.WriteLine("------------Points before invokng any method--------------------");
            for (int i = 0; i < points.Count; i++)
                points[i].Display();

            Console.WriteLine("\n------------Points after invokng the SetXCoordinate with amount = -11--------------------");
            for (int i = 0; i < points.Count; i++)
                points[i].SetXCoordinate(-11);
            for (int i = 0; i < points.Count; i++)
                points[i].Display();

        }

        public void translateAll()
        {
            Console.WriteLine("------------Points before invokng the translate method--------------------");
            for (int i = 0; i < points.Count; i++)
                points[i].Display();

            Console.WriteLine();
            for (int coordinateAxis = 1; coordinateAxis <=3;coordinateAxis++)
            {

                for (float amount = -10; amount <= 10; amount += 5)
                {
                    Console.WriteLine("------------Points after invokng the translate(" + coordinateAxis + "," + amount + ") with amount = " + amount + "--------------------");
                    R1Point currentPoint;
                    for (int i = 0; i < points.Count; i++)
                    {
                        currentPoint = points[i].translate(coordinateAxis, amount);
                        currentPoint.Display();
                    }

                    Console.WriteLine();
  
                }

                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }

            Console.WriteLine();
        }
            //for (int i = 0; i < points.Count; i++)
    }
}
