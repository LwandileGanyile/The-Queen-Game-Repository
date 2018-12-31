using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace BuildingBlocks
{
    public class DoubleLinkedList<T>:MyLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        DoubleLinkedList()
        {
            _head = null;
            _tail = null;
        }

        DoubleLinkedList(List<T> objects)
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
                    Node<T> current = _head;

                    for (int index = 1; index < elementIndex; index++)
                        current = current.next;
                    Node<T> temp = current.next;
                    current.next = new Node<T>(element);
                    (current.next).next = temp;
                    size++;
                }
            
        }

        public override void addFirst(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (_head == null)
                _head = _tail = newNode;
            else
            {
                Node<T> temp = _head;
                _head = newNode;
                newNode.next = temp;
                
            }
            size++;
        }

        public override void addLast(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (_tail == null)
                _head = _tail = newNode;
            else {

                _tail.next = newNode;
                _tail = _tail.next;
            }
            size++;
        }

        public override T getFirst()
        {
            throw new NotImplementedException();
        }

        public override T getLast()
        {
            throw new NotImplementedException();
        }

        public override T remove(int elementIndex)
        {
            throw new NotImplementedException();
        }

        public override T removeFirst()
        {
            throw new NotImplementedException();
        }

        public override T removeLast()
        {
            throw new NotImplementedException();
        }
    }
}
