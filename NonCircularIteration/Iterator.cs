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
        protected Node<T> current;

        protected Iterator()
        {

        }

        protected Iterator(Node<T> current)
        {

        }

        public abstract T GetNext();
        public abstract T GetPrevious();
        public abstract bool HasNext();
        public abstract bool HasPrevious();
        public abstract T Remove();
    }
}
