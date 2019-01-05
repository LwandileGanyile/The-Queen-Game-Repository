using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace BuildingBlocks
{
    public class CircularLinkedList<T> : MyLinkedList<T>
    {
        private MyNode<T> _head;
        

        public CircularLinkedList()
        {
            _head = null;
        }

        public CircularLinkedList(T[] objects) : base(objects)
        {
            

        }

        public CircularLinkedList(List<T> objects): base(objects)
        {
                

        }

        public override void add(T element, int elementIndex)
        {
            if (elementIndex == 0)
                addFirst(element);
            else if (elementIndex >= size)
                addLast(element);
            else
            {
                MyNode<T> current = _head;

                for (int index = 1; index < elementIndex; index++)
                    current = current.next;

                MyNode<T> temp = current.next;
                current.next = new MyNode<T>(element);
                (current.next).next = temp;
                size++;
            }
        }

        public override void displayList()
        {
            MyNode<T> current = _head;

            for (int i = 1; i <= size; i++)
            {
                if (current != null)
                {
                    Console.Write(current.element+" ");
                    current = current.next;
                }
                
            }
              
        }

        public override void addFirst(T element)
        {
            MyNode<T> newNode = new MyNode<T>(element);
            if (_head == null)
                _head  = newNode;
            else
            {
                MyNode<T> temp = _head;
                _head = newNode;
                newNode.next = temp;

            }
            size++;
        }

        public override void addLast(T element)
        {
            MyNode<T> lastNode = _head;

            for(int i = 0; i < size;i++)
            {
                if(lastNode.next != null)
                    lastNode = lastNode.next;
            }

            lastNode.next = new MyNode<T>(element);
            size++;
        }

        public override T getFirst()
        {
            return _head.element;
        }

        public override T getLast()
        {

            MyNode<T> current = _head;

            for (int i = 0; i < size-1; i++)
                current = current.next;

            return current.element;
        }

        public override T remove(int elementIndex)
        {
            if (elementIndex < 0 || elementIndex >= size)
            {
                return default(T);
            }
            else if (elementIndex == 0)
            {
                return removeFirst();
            }
            else if (elementIndex == size - 1)
            {
                return removeLast();
            }
            else
            {
                MyNode<T> prev = _head;

                for (int i = 1; i < elementIndex; i++)
                {
                    prev = prev.next;
                }

                MyNode<T> current = prev.next;
                prev.next = current.next;
                size--;

                return current.element;
            }
        }

        public override T removeFirst()
        {
            if (size == 0)
            {
                return default(T);
            }
            else
            {
                MyNode<T> temp = _head.next; // Keep the first node temporarily.
                _head = _head.next; // Move head to point to the next node.
                size--; // Reduce size by 1.

                return temp.element;
            }
        }

        public override T removeLast()
        {
            if (size == 0)
            {
                return default(T);
            }
            else if (size == 1)
            {
                MyNode<T> temp = _head;
                _head  = null;
                size = 0;
                return temp.element;
            }
            else
            {
                MyNode<T> current = _head;

                for (int i = 0; i < size - 1; i++)
                {
                    current = current.next;
                }

                MyNode<T> temp = current.next;
                size--;
                return temp.element;
            }
        }

        public override T getAt(int atElement)
        {
            

            if (atElement == 0)
                return getFirst();
            else if (atElement >= size - 1)
                return getLast();
            else
            {
                MyNode<T> current = _head;

                for (int i = 0; i < atElement; i++)
                    current = current.next;
                return current.element;
            }

        }
    }


}
