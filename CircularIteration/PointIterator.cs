using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharedResources;

namespace CircularIteration
{
    public class PointIterator<T> : Iterator<T>
    {
        

        public PointIterator()
        {

        }

        public PointIterator(int currentIndex,CircularLinkedList<T> circularLinkedList)
        :base(currentIndex,circularLinkedList)
        {

        }

        public override T GetNext()
        {

            if (currentIndex != -1)
            {
                
                currentIndex = (currentIndex + 1) % circularLinkedList.Size;
                return circularLinkedList.GetAt(currentIndex);
            }

            return default(T);
        }

        public override bool HasNext()
        {
           
            return currentIndex<circularLinkedList.Size;
        }

        public override T Remove()
        {

            if (currentIndex != -1)
            {
                return circularLinkedList.Remove((currentIndex + 1) % circularLinkedList.Size);
            }

                return default(T);
        }
    }
}
