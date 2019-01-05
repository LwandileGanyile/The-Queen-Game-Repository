using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Defination
{
    public interface IMyLinkedList<T>
    {
        void addFirst(T element);
        void addLast(T element);
        void add(T element);

        T getFirst();
        T getLast();
        T getAt(int atElement);

        void displayList();


        T removeFirst();
        T removeLast();

        void add(T element, int elementIndex);
        T remove(int elementIndex);

        bool isEmpty();
    }
}
