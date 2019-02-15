using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using SharedResources;

namespace CircularIteration
{
    public abstract class Iterator<T> : IUniIDirectionalIterator<T>
    {
        protected int currentIndex;
        protected CircularLinkedList<T> circularLinkedList;

        protected Iterator()
        {
            currentIndex = -1;
            circularLinkedList = new CircularLinkedList<T>();
        }

        protected Iterator(int currentIndex, CircularLinkedList<T> circularLinkedList)
        {
            this.circularLinkedList = circularLinkedList;
            this.currentIndex = currentIndex;
        }

        public abstract T GetNext();
        public abstract bool HasNext();
        public abstract T Remove();
    }
}
