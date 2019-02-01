using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace NonCircularIteration
{
    public class DirectionIterator<T> : Iterator<T>
    {
        public DirectionIterator()
        {

        }

        public DirectionIterator(Node<T> current)
        {

        }

        public override T GetNext()
        {
            throw new NotImplementedException();
        }

        public override T GetPrevious()
        {
            throw new NotImplementedException();
        }

        public override bool HasNext()
        {
            throw new NotImplementedException();
        }

        public override bool HasPrevious()
        {
            throw new NotImplementedException();
        }

        public override T Remove()
        {
            throw new NotImplementedException();
        }
    }
}
