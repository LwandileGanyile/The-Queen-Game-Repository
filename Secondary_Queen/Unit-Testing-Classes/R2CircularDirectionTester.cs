using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondary_Queen.Unit_Testing_Classes
{
    public class R2CircularDirectionTester
    {
        protected internal List<R2CircularDirection> directions;


        protected internal R2CircularDirectionTester()
        {
            directions = new List<R2CircularDirection>();
            CreateDirections();
        }

        protected internal R2CircularDirectionTester(List<R2CircularDirection> directions)
        {
            this.directions = directions;
        }

        protected internal R2CircularDirectionTester(R2CircularDirection direction)
        {
            directions = new List<R2CircularDirection> { direction };
        }

        // Fill the list of R2Point elements.
        private void CreateDirections()
        {


            Dictionary<int, int> duration = new Dictionary<int, int>();
           


            for (int i = 0; i < 10; i++)
            {
                duration.Add(i, 1000 / 10);
            }

            for (int direction = 1; direction <= 8; direction++)
            {
                directions.Add(new R2CircularDirection(new R2Point(10.0f, 10.0f), direction, 10, 1, duration, 1));
            }
        }

        // Checking the Display method in R2CircularDirection.
        public void DisplayDirections()
        {

            for (int direction = 1; direction <= 8; direction++)
            {
                Console.Write("Direction " + direction + " - \t");
                Console.Write("[ ");
                directions[direction - 1].Display();
                Console.Write(" ]\n\n ");

            }
        }

        // Checking isDimesnionCorrent, isPointDirectionCorrent, and isDirectionValid.
        public void checkDimensionAndValidity()
        {
            for (int index = 0; index < directions.Count;index++)
            { 
                
                Console.Write("is direction "+(index+1)+" - ");
                directions[index].Display();
                Console.WriteLine(" made up of two dimensional points ? "+ directions[index].IsPointDimensionCorrect()+".");

                Console.Write("Do direction "+ (index + 1) +" ");
                directions[index].Display();
                Console.WriteLine(" have a correct direction value ? " + directions[index].IsDirectionValid(directions[index].Direction) + ".");

                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }

        public void reflectAllAboutXAxis()
        {
            //List<R2CircularDirection> transformedDirections = new List<R2CircularDirection>();

            for (int i = 0; i < directions.Count;i++)
            {
                directions[i] = directions[i].ReflectAboutAxis(0);
                
            }
                
        }

        public void reflectAllAboutYAxis()
        {
            

            for (int i = 0; i < directions.Count; i++)
            {
                directions[i] = directions[i].ReflectAboutAxis(1);

            }

        }

        public void reflectAllAroundEqualAxis()
        {
            for (int i = 0; i < directions.Count; i++)
            {
                directions[i] = directions[i].ReflectAroundEqualAxis(new List<int> { -1,1},3);

            }
        }

        public void rotateAllAroundAxis()
        {
            for (int i = 0; i < directions.Count; i++)
            {
                directions[i] = directions[i].RotateAroundEqualAxis(new List<int> { 1, 1 }, 2);

            }
        }

        public void translateAll()
        {
            for (int j = 10; j <=50;j+= 10)
            {
                Console.WriteLine("Display NEW DIRECTION TRANSLATED "+j+" UNITS FROM INITIAL POSITION.");
                for (int i = 0; i < directions.Count; i++)
                {
                    directions[i] = directions[i].translate(i+1,j);

                }

                DisplayDirections();
                Console.WriteLine();
            }
        }

        

    }
}
