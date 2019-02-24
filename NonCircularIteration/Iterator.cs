using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using SharedResources;

namespace NonCircularIteration
{
    public abstract class Iterator<T> : IBiIDirectionalIterator<T>
    {
        protected int currentIndex;
        protected DoubleLinkedList<T> doubleLinkedList;

        protected Iterator()
        {

        }

        protected Iterator(int currentIndex, DoubleLinkedList<T> doubleLinkedList)
        {
            this.doubleLinkedList = doubleLinkedList;
            this.currentIndex = currentIndex;
        }

        public T GetNext()
        {

            if (currentIndex != -1)
            {

                currentIndex = (currentIndex + 1) % doubleLinkedList.Size;
                return doubleLinkedList.GetAt(currentIndex);
            }

            return default(T);
        }

        public bool HasNext()
        {

            return currentIndex < doubleLinkedList.Size;
        }

        public T Remove()
        {

            if (currentIndex != -1)
            {
                return doubleLinkedList.Remove((currentIndex + 1) % doubleLinkedList.Size);
            }

            return default(T);
        }

        public bool HasPrevious()
        {
            return currentIndex > 0;

        }

        public T GetPrevious()
        {
            if(currentIndex>0)
                return doubleLinkedList.GetAt(currentIndex-1);
            return default(T);
        }
    }
}
