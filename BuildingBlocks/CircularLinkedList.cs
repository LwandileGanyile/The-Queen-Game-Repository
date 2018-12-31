using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace BuildingBlocks
{
    public class CircularLinkedList<T> : IMyLinkedList<T>
    {
        private MyNode<T> _head;
        

        CircularLinkedList()
        {
            _head = null;
        }

        CircularLinkedList(List<T> objects)
        {

        }

        public void add(T element, int elementIndex)
        {
            throw new NotImplementedException();
        }

        public void addFirst(T element)
        {
            throw new NotImplementedException();
        }

        public void addLast(T element)
        {
            throw new NotImplementedException();
        }

        public T getFirst()
        {
            throw new NotImplementedException();
        }

        public T getLast()
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public T remove(int elementIndex)
        {
            throw new NotImplementedException();
        }

        public T removeFirst()
        {
            throw new NotImplementedException();
        }

        public T removeLast()
        {
            throw new NotImplementedException();
        }
    }
}
