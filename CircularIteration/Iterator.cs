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
        protected MyNode<T> current;

        protected Iterator()
        {

        }

        protected Iterator(MyNode<T> current)
        {

        }

        public abstract T GetNext();
        public abstract bool HasNext();
        public abstract T Remove();
    }
}
