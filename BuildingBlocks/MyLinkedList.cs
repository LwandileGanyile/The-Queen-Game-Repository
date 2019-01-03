using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace BuildingBlocks
{
    public abstract class MyLinkedList<T>:IMyLinkedList<T>
    {
        protected int size;

        protected MyLinkedList()
        {
            size = 0;
        }

        protected MyLinkedList(T[] objects)
        {
            for (int index = 0; index < objects.Length; index++)
                add(objects[index],size);
        }

        protected MyLinkedList(List<T> objects)
        {
            for (int index = 0; index < objects.Count; index++)
                addLast(objects[index]);
        }

        public abstract void add(T element, int elementIndex);
        public abstract void addFirst(T element);
        public abstract void addLast(T element);
        public abstract T getFirst();
        public abstract T getLast();

        public bool isEmpty()
        {
            return size == 0;
        }

        public abstract T remove(int elementIndex);
        public abstract T removeFirst();
        public abstract T removeLast();

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
