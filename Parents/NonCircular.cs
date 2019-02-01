using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace SharedResources
{
    public abstract class NonCircular<T,U> :Parent<T>
    {
        protected int numberOfRepeatations;
        protected DoubleLinkedList<U> doubleLinkedList;

        public NonCircular():base()
        {
            numberOfRepeatations = 1;
            doubleLinkedList = new DoubleLinkedList<U>();
        }

        protected NonCircular(Point _startingPoint, int direction,
        Dictionary<int,int> duration, int directionDimension, int numberOfRepeatations)
        :base(_startingPoint, direction,
        duration,directionDimension)
        {

            this.numberOfRepeatations = numberOfRepeatations;
            doubleLinkedList = new DoubleLinkedList<U>();
            
        }

        protected NonCircular(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int,int> duration, int directionDimension, int numberOfRepeatations)
        :base(_startingPoint, direction,
        canShootList, duration, directionDimension)
        {

            this.numberOfRepeatations = numberOfRepeatations;
            
            doubleLinkedList = new DoubleLinkedList<U>();
            
        }

        public int NumberOfRepeatations
        {
            set;
            get;
        }

        protected void FillCanShootList()
        {
            for (int i = 0; i < doubleLinkedList.Size; i++)
                canShootList.Add(false);
        }

        
        public override void Clear()
        {
            doubleLinkedList.Clear();
        }
    }
}
