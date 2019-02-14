using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primary_Queen;
using Primary_Queen.Unit_Testing_Classes;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            R1CircularDirectionTester tester = new R1CircularDirectionTester();

            /*R1CircularDirection r1Direction = new R1CircularDirection();

            R1CircularDirection translatedR1Direction;
            R1CircularDirection translatedR2Direction;

            List<bool> canShoot = new List<bool>();
            

            float directionLength = 5;
            float directionDivisor = 0.5f;

            int numberOfElements = (int)(directionLength / directionDivisor);
            Dictionary<int, int> duration = new Dictionary<int, int>();



            int direction = 1;



            for (int i = 1; i <= numberOfElements; i++)
            {
                if (i % 2 == 0)
                    canShoot.Add(false);
                else
                    canShoot.Add(true);

                duration.Add(i - 1, (int)(1000 / numberOfElements));
            }

            R1CircularDirection r2Direction = new R1CircularDirection(new R1Point(0),direction,directionLength,directionDivisor,duration);
            

            Console.Write("------------------------Before calling the translate(" + 1 + "," + 5 + ") method on ");
            r1Direction.Display();
            Console.WriteLine(".-------------");
            r1Direction.Display();
            Console.WriteLine();

            Console.Write("------------------------After calling the translate(" + 1 + "," + 5 + ") method on ");
            r1Direction.Display();
            Console.WriteLine(".-------------");

            translatedR1Direction = r1Direction.translate(1, 5);
            Console.Write("Direction 1");
            translatedR1Direction.Display();
            Console.WriteLine();


            Console.Write("------------------------Before calling the translate(" + 2 + "," + 5 + ") method on ");
            r2Direction.Display();
            Console.WriteLine(".-------------");
            r2Direction.Display();
            Console.WriteLine();

            Console.Write("------------------------After calling the translate(" + 2 + "," + 5 + ") method on ");
            r2Direction.Display();
            Console.WriteLine(".-------------");

            translatedR2Direction = r2Direction.translate(1, 5);
            translatedR2Direction.Display();
            Console.WriteLine();*/


            Console.WriteLine("Primary Queen Main" );
            Console.ReadLine();
        }
    }
}
