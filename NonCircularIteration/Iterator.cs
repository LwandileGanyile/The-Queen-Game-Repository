using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace NonCircularIteration
{
    public abstract class Iterator<T> : IBidirectionalIterator<T>
    {
        protected Node<T> current;

        protected Iterator()
        {

        }

        protected Iterator(Node<T> current)
        {

        }

        public abstract T getNext();
        public abstract T getPrevious();
        public abstract bool hasNext();
        public abstract bool hasPrevious();
        public abstract T remove();
    }
}
