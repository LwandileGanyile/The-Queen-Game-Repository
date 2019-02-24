using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;


namespace SharedResources
{
    public abstract class Circular<T,U>: Parent<T>
    {
        protected int numberOfRotations;
        protected CircularLinkedList<U> circularLinkedList;

       


        protected Circular()
        :base(){
            numberOfRotations = 1;
            circularLinkedList = new CircularLinkedList<U>();


        }

        protected Circular(Point _startingPoint, int direction,
        Dictionary<int,int> duration, int dimension,int numberOfRotations)
        :base(_startingPoint,direction,
        duration,dimension)
        {
            
            this.numberOfRotations = numberOfRotations;
            circularLinkedList = new CircularLinkedList<U>();
        }

        protected Circular(Point _startingPoint, int direction,
        List<bool> canShootList,Dictionary<int,int> duration, int directionDimension, int numberOfRotations)
        :base(_startingPoint,direction,
        canShootList, duration, directionDimension)
        {

            this.numberOfRotations = numberOfRotations;
            circularLinkedList = new CircularLinkedList<U>();
      
        }

        protected Circular(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension,
        CircularLinkedList<U> circularLinkedList,int numberOfRotations)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension)
        {

            this.numberOfRotations = numberOfRotations;
            this.circularLinkedList = circularLinkedList; 

        }

       

        public int NumberOfRotations
        {
            set;
            get;
        }

        

        public override void Clear()
        {
            circularLinkedList.Clear();
        }

       
        
        
    }
}
