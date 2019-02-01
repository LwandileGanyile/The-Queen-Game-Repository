using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharedResources;

namespace CircularIteration
{
    public class LetterIterator<T> : Iterator<T>
    {


        public LetterIterator()
        {

        }

        public LetterIterator(MyNode<T> current)
        {

        }

        public override T GetNext()
        {
            throw new NotImplementedException();
        }

        public override bool HasNext()
        {
            throw new NotImplementedException();
        }

        public override T Remove()
        {
            throw new NotImplementedException();
        }
    }
}
