﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using Game_Defination;

namespace SharedResources
{
    public abstract class Parent<T>:IRotate<T>, IReflect<T>, IReflectable<T>,
        ITranslate<T>, IDirectionDimension, IPointDimension, IDisplay, ICompare<T>, IInitialize, IFill
    {

        protected Point _startingPoint;

        protected int direction;
        protected List<bool> canShootList;
        protected  Dictionary<int,int> duration;
        // Letters are made up of directions, each piece of a direction equals to divisor.
        protected int dimension; // Dimenison.

        protected Parent()
        {
            _startingPoint = null;
            direction = 2;
            duration = new Dictionary<int, int>();
            dimension = -1;
            canShootList = new List<bool>();

        }

       

        protected Parent(Point _startingPoint, int direction,
        Dictionary<int,int> duration, int directionDimension)
        {
            this._startingPoint = _startingPoint;
            this.direction = direction;
            this.duration = duration;
            canShootList = canShootList = new List<bool>(); ;
            dimension = _startingPoint.Dimension;
        }

        protected Parent(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int,int> duration, int directionDimension)
        {
            this._startingPoint = _startingPoint;
            this.direction = direction;
            this.duration = duration;
            dimension = _startingPoint.Dimension;
            this.canShootList = canShootList;
        }

        public int Direction
        {
            get
            {
                return direction;
            }

            set
            {
                Clear();
                direction = value;
               
            }

        }
        public int Dimension { get { return dimension; } }
        public Dictionary<int,int> Duration
        {
            get
            {
                return duration; }
            set
            {
                
            }
        }
        public List<bool> CanShoot
        {
            get
            {
                return canShootList;
            }

            set
            {
                if (value.Count == canShootList.Count)
                    canShootList = value;
            }
        }

        public Point StartingPoint {

            get
            {
                return _startingPoint;
            }

            set
            {
                Clear();
                _startingPoint = value;
               
            }
        }

        public override string ToString()
        {
            return "Facing direction : " + Direction + "\nStarting At : " + 
            _startingPoint.ToString() +  "\nCanShooList : "+GetCanShootPresentation()+ 
            "\nDimension : " + Dimension + "\nDuration directory : \n"+GetDurationPresentation();
        }

        private string GetCanShootPresentation()
        {
            string output = "[ ";


            for (int i = 0; i < canShootList.Count - 1; i++)
                if (canShootList[i])
                    output += "True, ";
                else
                    output += "False, ";

            if (canShootList[canShootList.Count - 1])
                output += "True ]";
            else
                output += "False ]";


            return output;
        }

        private string GetDurationPresentation()
        {
            string output = "";

            foreach (KeyValuePair<int,int> keyValuePair in duration)
            {
                output += ("\t\tKey : "+keyValuePair.Key.ToString()+"\tTakes : " + keyValuePair.Value.ToString()+" milliseconds.");
                output += "\n";
            }

            return output;
        }

        public abstract void Clear();
        public abstract T RotateAroundAxis(int indexOfAxis, int numberOfTimes);
        public abstract bool IsPointDimensionCorrect();
        public abstract T ReflectAboutAxis(int axisIndex);
        public abstract bool IsDirectionDimensionCorrect();
        public abstract T ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes);
        public abstract T RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes);
        public abstract T translate(int coordinateSystemDirection, float amaunt);

        public abstract void Display();

        // Display whether or not each point/direction/letter can do another strategy such as shooting.
        public void DisplayCanShoot()
        {
            for (int i = 1; i <= canShootList.Count; i++)
                Console.Write(canShootList[i - 1] + " ");
            Console.WriteLine();
        }

        public abstract int CompareTo(T comparableInstance);
        public abstract T ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes);
        public abstract void initializeAttributes();
        public abstract void Fill();
    }
}
