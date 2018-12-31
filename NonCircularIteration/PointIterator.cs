using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace NonCircularIteration
{
    public class PointIterator<T> : Iterator<T>
    {

        public PointIterator()
        {

        }

        public PointIterator(Node<T> current)
        {

        }

        public override T getNext()
        {
            throw new NotImplementedException();
        }

        public override T getPrevious()
        {
            throw new NotImplementedException();
        }

        public override bool hasNext()
        {
            throw new NotImplementedException();
        }

        public override bool hasPrevious()
        {
            throw new NotImplementedException();
        }

        public override T remove()
        {
            throw new NotImplementedException();
        }
    }
}
