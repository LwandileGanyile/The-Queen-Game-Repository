using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class CircularDirection<T,U>: Circular<T,U>,IDirection,ICanShoot
    {
        
        protected float _directionLength;
        protected float _divisor;

        protected CircularDirection():base()
        {
            _divisor = 1;
            _directionLength = 10;

        }

        // Construct without specifying the canshoot property.
        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int,int> duration, int directionDimension, int numberOfRotations)
        : base(startingPoint, direction, divisor, duration, directionDimension, numberOfRotations)
        {
            _divisor = divisor;
            _directionLength = directionLength;
        }

        // Construct without specifying the  length property cause it doesnh't exist.
        protected CircularDirection(Point startingPoint, int direction,
        float directionDivisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension)
        : base(startingPoint, direction, directionDivisor, canShootList, duration, directionDimension, 1)
        {
            _divisor = directionDivisor;
            _directionLength = 10 * _divisor;
        }

        // Construct without specifying the number of rotations.
        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList,Dictionary<int,int> duration, int directionDimension)
        :base(startingPoint, direction, directionDivisor, canShootList,duration,directionDimension,1)
        {
            _divisor = directionDivisor;
            _directionLength = directionLength;
        }

        // Construct by specifying the number of rotations.
        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension,int numberOfRotations)
        : base(startingPoint, direction, directionDivisor, canShootList, duration, directionDimension, numberOfRotations)
        {
            _divisor = directionDivisor;
            _directionLength = directionLength;
        }

        

        

        public float Divisor { get { return _divisor; } }
        public float DirectioLength
        {
            get { return _directionLength; }
        }


        // Returns a positive integer representing this direction.
        public int GetDirection() { return direction; }
        // Returns a direction divisor.
        public float GetDirectionDivisor() { return _divisor; }
        // Returns a direction length;
        public float GetDirectionLength() { return _directionLength; }
        // Checks whether or not the direction is valid.
        public abstract bool IsDirectionValid(int direction);
        // Update the points in this direction that can shoot.
        public void SetCanShootList(List<bool> canShootList) { this.canShootList = canShootList; }
        // Sets the divisor of this direction.
        public void SetDirectionDivisor(float directionDivisor)
        {
            _divisor = directionDivisor;
            circularLinkedList.Clear();
            Fill();

        }
        // Sets the length of this direction.
        public void SetDirectionLength(float directionLength)
        {
            _directionLength = directionLength;

            circularLinkedList.Clear();
            Fill();
        }
        
        // Display whether or not each point can shoot.
        public void DisplayCanShoot()
        {
            for (int i = 1; i <= canShootList.Count; i++)
                Console.Write(canShootList[i - 1] + " ");
            Console.WriteLine();
        }
       
       

    }

}
