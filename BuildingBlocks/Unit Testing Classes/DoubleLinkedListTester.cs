using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Unit_Testing_Classes
{
    public class DoubleLinkedListTester
    {

        protected internal DoubleLinkedList<int> doubleLinkedList11;
        protected internal DoubleLinkedList<int> doubleLinkedList22;
        protected internal DoubleLinkedList<int> doubleLinkedList33;
        protected internal DoubleLinkedList<int> doubleLinkedList44;

        protected internal DoubleLinkedList<char> doubleLinkedList111;
        protected internal DoubleLinkedList<char> doubleLinkedList222;
        protected internal DoubleLinkedList<char> doubleLinkedList333;
        protected internal DoubleLinkedList<char> doubleLinkedList444;

        protected internal DoubleLinkedList<string> doubleLinkedList1111;
        protected internal DoubleLinkedList<string> doubleLinkedList2222;
        protected internal DoubleLinkedList<string> doubleLinkedList3333;
        protected internal DoubleLinkedList<string> doubleLinkedList4444;

        protected internal DoubleLinkedListTester()
        {
            int[] list1 = { 11, 21, 31, 41, 51, 61 };
            int[] list2 = { 111, 222, 333, 444, 5, 6, 7, 8, 9 };
            int[] list3 = { 17, 72, 3, 4, 95, 6, 7, 86, 9, 10, 11, 12 };
            int[] list4 = { 10, 82, 3, 774, 50, 6, 7, 438, 9, 00, 11, 120, 145 };



            string[] names1 = { "Lwandile", "Sakhile", " Snothi" };
            string[] names2 = { "Sakhile", "Lwandile", " Snothi", " Thabani" };
            string[] names3 = { "Sakhile", " Snothi", " Thabani", "Njabulo", "Lwandile" };
            string[] names4 = { "Njabulo", "Lwandile", "Sakhile", " Snothi", " Thabani", "Ndumiso" };

            char[] chars1 = { 'a', 'b', 'c' };
            char[] chars2 = { 'b', 'c', 'd', 'a' };
            char[] chars3 = { 'd', 'a', 'b', 'c', 'e' };
            char[] chars4 = { 'c', 'b', 'd', 'a', 'e', 'f' };


            doubleLinkedList11 = new DoubleLinkedList<int>(list1);
            doubleLinkedList22 = new DoubleLinkedList<int>(list2);
            doubleLinkedList33 = new DoubleLinkedList<int>(list3);
            doubleLinkedList44 = new DoubleLinkedList<int>(list4);

            doubleLinkedList111 = new DoubleLinkedList<char>(chars1);
            doubleLinkedList222 = new DoubleLinkedList<char>(chars2);
            doubleLinkedList333 = new DoubleLinkedList<char>(chars3);
            doubleLinkedList444 = new DoubleLinkedList<char>(chars4);

            doubleLinkedList1111 = new DoubleLinkedList<string>(names1);
            doubleLinkedList2222 = new DoubleLinkedList<string>(names2);
            doubleLinkedList3333 = new DoubleLinkedList<string>(names3);
            doubleLinkedList4444 = new DoubleLinkedList<string>(names4);

        }

        protected internal DoubleLinkedListTester(DoubleLinkedList<int> doubleLinkedList11, DoubleLinkedList<int> doubleLinkedList22,
         DoubleLinkedList<int> doubleLinkedList33, DoubleLinkedList<int> doubleLinkedList44,
         DoubleLinkedList<char> doubleLinkedList111, DoubleLinkedList<char> doubleLinkedList222,
         DoubleLinkedList<char> doubleLinkedList333, DoubleLinkedList<char> doubleLinkedList444,
         DoubleLinkedList<string> doubleLinkedList1111, DoubleLinkedList<string> doubleLinkedList2222,
         DoubleLinkedList<string> doubleLinkedList3333, DoubleLinkedList<string> doubleLinkedList4444)
        {
            this.doubleLinkedList11 = doubleLinkedList11;
            this.doubleLinkedList22 = doubleLinkedList22;
            this.doubleLinkedList33 = doubleLinkedList33;
            this.doubleLinkedList44 = doubleLinkedList44;

            this.doubleLinkedList111 = doubleLinkedList111;
            this.doubleLinkedList222 = doubleLinkedList222;
            this.doubleLinkedList333 = doubleLinkedList333;
            this.doubleLinkedList444 = doubleLinkedList444;

            this.doubleLinkedList1111 = doubleLinkedList1111;
            this.doubleLinkedList2222 = doubleLinkedList2222;
            this.doubleLinkedList3333 = doubleLinkedList3333;
            this.doubleLinkedList4444 = doubleLinkedList4444;
        }

        public void testCircularLinkedList()
        {
            print();

            testGetMethods();

            testAddMethods();

            testRemoveMethods();

        }

        public void testRemoveMethods()
        {
            Console.WriteLine("----------Testing  removeFirst(), removeAt(int index) & removeLast() on the Circular linked list class--------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------removeFirst()------------------------------");
            Console.WriteLine("Remove first on list1 " + doubleLinkedList11.removeFirst());
            Console.WriteLine("Remove first on list2 " + doubleLinkedList22.removeFirst());
            Console.WriteLine("Remove first on list3 " + doubleLinkedList33.removeFirst());
            Console.WriteLine("Remove first on list4 " + doubleLinkedList44.removeFirst());

            Console.WriteLine();

            Console.WriteLine("Remove first on chars1 " + doubleLinkedList111.removeFirst());
            Console.WriteLine("Remove first on chars2 " + doubleLinkedList222.removeFirst());
            Console.WriteLine("Remove first on chars3 " + doubleLinkedList333.removeFirst());
            Console.WriteLine("Remove first on chars4 " + doubleLinkedList444.removeFirst());

            Console.WriteLine();

            Console.WriteLine("Remove first on names1 " + doubleLinkedList1111.removeFirst());
            Console.WriteLine("Remove first on names2 " + doubleLinkedList2222.removeFirst());
            Console.WriteLine("Remove first on names3 " + doubleLinkedList3333.removeFirst());
            Console.WriteLine("Remove first on names4 " + doubleLinkedList4444.removeFirst());

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------removeAt(index)------------------------------");
            Console.WriteLine("Remove element at '4' on list1, " + doubleLinkedList11.remove(4) + " removed.");
            Console.WriteLine("Remove element at '2' on list2, " + doubleLinkedList22.remove(2) + " removed.");
            Console.WriteLine("Remove element at '3' on list3, " + doubleLinkedList33.remove(3) + " removed.");
            Console.WriteLine("Remove element at '1' on list4, " + doubleLinkedList44.remove(1) + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove element at '1' on chars1, " + doubleLinkedList111.remove(1) + " removed.");
            Console.WriteLine("Remove element at '2' on chars2, " + doubleLinkedList222.remove(2) + " removed.");
            Console.WriteLine("Remove element at '3' on chars3, " + doubleLinkedList333.remove(3) + " removed.");
            Console.WriteLine("Remove element at '4' on chars4, " + doubleLinkedList444.remove(4) + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove element at '3' on names1, " + doubleLinkedList1111.remove(3) + " removed.");
            Console.WriteLine("Remove element at '2' on names2, " + doubleLinkedList2222.remove(2) + " removed.");
            Console.WriteLine("Remove element at '4' on names3, " + doubleLinkedList3333.remove(4) + " removed.");
            Console.WriteLine("Remove element at '0' on names4, " + doubleLinkedList4444.remove(0) + " removed.");

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------removeLast()------------------------------");
            Console.WriteLine("Remove last on list1, " + doubleLinkedList11.removeLast() + " removed.");
            Console.WriteLine("Remove last on list2, " + doubleLinkedList22.removeLast() + " removed.");
            Console.WriteLine("Remove last on list3, " + doubleLinkedList33.removeLast() + " removed.");
            Console.WriteLine("Remove last on list4, " + doubleLinkedList44.removeLast() + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove last on chars1, " + doubleLinkedList111.removeLast() + " removed.");
            Console.WriteLine("Remove last on chars2, " + doubleLinkedList222.removeLast() + " removed.");
            Console.WriteLine("Remove last on chars3, " + doubleLinkedList333.removeLast() + " removed.");
            Console.WriteLine("Remove last on chars4, " + doubleLinkedList444.removeLast() + " removed.");


            Console.WriteLine();

            Console.WriteLine("Remove last on names1, " + doubleLinkedList1111.removeLast() + " removed.");
            Console.WriteLine("Remove last on names2, " + doubleLinkedList2222.removeLast() + " removed.");
            Console.WriteLine("Remove last on names3, " + doubleLinkedList3333.removeLast() + " removed.");
            Console.WriteLine("Remove last on names4, " + doubleLinkedList4444.removeLast() + " removed.");

            Console.WriteLine();

            print();

            Console.WriteLine();
        }

        public void testAddMethods()
        {
            Console.WriteLine("----------Testing  addFirst(), addAt(int index) & addLast() on the Circular linked list class--------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------addFirst()------------------------------");
            Console.WriteLine("Add first '23' of list1 ");
            doubleLinkedList11.addFirst(23);
            Console.WriteLine("Add first '35'  of list2 ");
            doubleLinkedList22.addFirst(35);
            Console.WriteLine("Add first '76'  of list3 ");
            doubleLinkedList33.addFirst(76);
            Console.WriteLine("Add first '102'  of list4 ");
            doubleLinkedList44.addFirst(102);

            Console.WriteLine();

            Console.WriteLine("Add first 'i' on chars1 ");
            doubleLinkedList111.addFirst('i');
            Console.WriteLine("Add first 'r' on chars2 ");
            doubleLinkedList222.addFirst('r');
            Console.WriteLine("Add first 'e' on chars3 ");
            doubleLinkedList333.addFirst('e');
            Console.WriteLine("Add first 'w' on chars4 ");
            doubleLinkedList444.addFirst('w');

            Console.WriteLine();

            Console.WriteLine("Add first 'Justin' on names1 ");
            doubleLinkedList1111.addFirst("Justin");
            Console.WriteLine("Add first 'Melvin' on names2 ");
            doubleLinkedList2222.addFirst("Melvin");
            Console.WriteLine("Add first 'Kalen' on names3 ");
            doubleLinkedList3333.addFirst("Kalen");
            Console.WriteLine("Add first 'Tu' on names4 ");
            doubleLinkedList4444.addFirst("Tu");

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------addAt(E element,3)------------------------------");
            Console.WriteLine("Add '1000' at '3' on list1 ");
            doubleLinkedList11.add(1000, 3);
            Console.WriteLine("Add '2000' at '4' on list2 ");
            doubleLinkedList22.add(2000, 4);
            Console.WriteLine("Add '5000' at '0' on list3 ");
            doubleLinkedList33.add(5000, 0);
            Console.WriteLine("Add '20200' at '2' on list4 ");
            doubleLinkedList44.add(20200, 2);

            Console.WriteLine();

            Console.WriteLine("Add 'f' at '0' on chars1 ");
            doubleLinkedList111.add('f', 0);
            Console.WriteLine("Add 's' at '2' on chars2 ");
            doubleLinkedList222.add('s', 2);
            Console.WriteLine("Add 'q' at '4' on chars3 ");
            doubleLinkedList333.add('q', 4);
            Console.WriteLine("Add 'm' at '6' on chars4 ");
            doubleLinkedList444.add('m', 6);

            Console.WriteLine();

            Console.WriteLine("Add 'Nolwazi' at '4' on names1 ");
            doubleLinkedList1111.add("Nolwazi", 4);
            Console.WriteLine("Add 'Lizwi' at '3' on names2 ");
            doubleLinkedList2222.add("Lizwi", 3);
            Console.WriteLine("Add 'Scelo' at '7' on names3 ");
            doubleLinkedList3333.add("Scelo", 7);
            Console.WriteLine("Add 'Cebo' at '0' on names4 ");
            doubleLinkedList4444.add("Cebo", 0);

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------addLast(T element)------------------------------");
            Console.WriteLine("Add last '4' on list1 ");
            doubleLinkedList11.addLast(4);
            Console.WriteLine("Add last '5' on list2 ");
            doubleLinkedList22.addLast(5);
            Console.WriteLine("Add last '6' on list3 ");
            doubleLinkedList33.addLast(6);
            Console.WriteLine("Add last '7' of list4 ");
            doubleLinkedList44.addLast(7);

            Console.WriteLine();

            Console.WriteLine("Add last 'k' on chars1 ");
            doubleLinkedList111.addLast('k');
            Console.WriteLine("Add last 'i' on chars2 ");
            doubleLinkedList222.addLast('i');
            Console.WriteLine("Add last 't' on chars3 ");
            doubleLinkedList333.addLast('t');
            Console.WriteLine("Add last 'x' on chars4 ");
            doubleLinkedList444.addLast('x');

            Console.WriteLine();

            Console.WriteLine("Add last 'Wendy' on names1 ");
            doubleLinkedList1111.addLast("Wendy");
            Console.WriteLine("Add last 'Anele' on names2 ");
            doubleLinkedList2222.addLast("Anele");
            Console.WriteLine("Add last 'Samke' on names3 ");
            doubleLinkedList3333.addLast("Samke");
            Console.WriteLine("Add last 'Anathi' on names4 ");
            doubleLinkedList4444.addLast("Anathi");

            Console.WriteLine();

            print();

            Console.WriteLine();
        }

        public void testGetMethods()
        {
            Console.WriteLine("----------Testing  getFirst(), getAt(int index) & getLast() on the Circular linked list class--------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------getFirst()------------------------------");
            Console.WriteLine("First value of list1 " + doubleLinkedList11.getFirst());
            Console.WriteLine("First value of list2 " + doubleLinkedList22.getFirst());
            Console.WriteLine("First value of list3 " + doubleLinkedList33.getFirst());
            Console.WriteLine("First value of list4 " + doubleLinkedList44.getFirst());

            Console.WriteLine();

            Console.WriteLine("First value of chars1 " + doubleLinkedList111.getFirst());
            Console.WriteLine("First value of chars2 " + doubleLinkedList222.getFirst());
            Console.WriteLine("First value of chars3 " + doubleLinkedList333.getFirst());
            Console.WriteLine("First value of chars4 " + doubleLinkedList444.getFirst());

            Console.WriteLine();

            Console.WriteLine("First value of names1 " + doubleLinkedList1111.getFirst());
            Console.WriteLine("First value of names2 " + doubleLinkedList2222.getFirst());
            Console.WriteLine("First value of names3 " + doubleLinkedList3333.getFirst());
            Console.WriteLine("First value of names4 " + doubleLinkedList4444.getFirst());

            Console.WriteLine();

            Console.WriteLine("----------------getAt(3)------------------------------");
            Console.WriteLine("At value of list1 " + doubleLinkedList11.getAt(3));
            Console.WriteLine("At value of list2 " + doubleLinkedList22.getAt(3));
            Console.WriteLine("At value of list3 " + doubleLinkedList33.getAt(3));
            Console.WriteLine("At value of list4 " + doubleLinkedList44.getAt(3));

            Console.WriteLine();

            Console.WriteLine("At value of chars1 " + doubleLinkedList111.getAt(3));
            Console.WriteLine("At value of chars2 " + doubleLinkedList222.getAt(3));
            Console.WriteLine("At value of chars3 " + doubleLinkedList333.getAt(3));
            Console.WriteLine("At value of chars4 " + doubleLinkedList444.getAt(3));

            Console.WriteLine();

            Console.WriteLine("At value of names1 " + doubleLinkedList1111.getAt(3));
            Console.WriteLine("At value of names2 " + doubleLinkedList2222.getAt(3));
            Console.WriteLine("At value of names3 " + doubleLinkedList3333.getAt(3));
            Console.WriteLine("At value of names4 " + doubleLinkedList4444.getAt(3));

            Console.WriteLine();

            Console.WriteLine("----------------getLast()------------------------------");
            Console.WriteLine("Last value of list1 " + doubleLinkedList11.getLast());
            Console.WriteLine("Last value of list2 " + doubleLinkedList22.getLast());
            Console.WriteLine("Last value of list3 " + doubleLinkedList33.getLast());
            Console.WriteLine("Last value of list4 " + doubleLinkedList44.getLast());

            Console.WriteLine();

            Console.WriteLine("Last value of chars1 " + doubleLinkedList111.getLast());
            Console.WriteLine("Last value of chars2 " + doubleLinkedList222.getLast());
            Console.WriteLine("Last value of chars3 " + doubleLinkedList333.getLast());
            Console.WriteLine("Last value of chars4 " + doubleLinkedList444.getLast());

            Console.WriteLine();

            Console.WriteLine("Last value of names1 " + doubleLinkedList1111.getLast());
            Console.WriteLine("Last value of names2 " + doubleLinkedList2222.getLast());
            Console.WriteLine("Last value of names3 " + doubleLinkedList3333.getLast());
            Console.WriteLine("Last value of names4 " + doubleLinkedList4444.getLast());

            Console.WriteLine();


            print();
        }

        public void print()
        {

            Console.WriteLine("-----List Elements------&-----Size Property------------------------------");
            Console.Write("Elements of list1 -> ");
            doubleLinkedList11.displayList();
            Console.WriteLine("\t\tSize of list1 :" + doubleLinkedList11.Size);

            Console.Write("Elements of list2 -> ");
            doubleLinkedList22.displayList();
            Console.WriteLine("\t\tSize of list2 : " + doubleLinkedList22.Size);

            Console.Write("Elements of list3 -> ");
            doubleLinkedList33.displayList();
            Console.WriteLine("\t\tSize of list3 : " + doubleLinkedList33.Size);

            Console.Write("Elements of list4 -> ");
            doubleLinkedList44.displayList();
            Console.WriteLine("\t\tSize of list4 : " + doubleLinkedList44.Size);

            Console.WriteLine();

            Console.Write("Elements of chars1 -> ");
            doubleLinkedList111.displayList();
            Console.WriteLine("\t\tSize of chars1 : " + doubleLinkedList111.Size);

            Console.Write("Elements of chars2 -> ");
            doubleLinkedList222.displayList();
            Console.WriteLine("\t\tSize of chars2 : " + doubleLinkedList222.Size);

            Console.Write("Elements of chars3 -> ");
            doubleLinkedList333.displayList();
            Console.WriteLine("\t\tSize of chars3 : " + doubleLinkedList333.Size);

            Console.Write("Elements of chars4 -> ");
            doubleLinkedList444.displayList();
            Console.WriteLine("\t\tSize of chars4 : " + doubleLinkedList444.Size);
            Console.WriteLine();

            Console.Write("Elements of names1 -> ");
            doubleLinkedList1111.displayList();
            Console.WriteLine("\t\tSize of names1 : " + doubleLinkedList1111.Size);

            Console.Write("Elements of names2 -> ");
            doubleLinkedList2222.displayList();
            Console.WriteLine();
            Console.WriteLine("\t\tSize of names2 : " + doubleLinkedList2222.Size);

            Console.Write("Elements of names3 -> ");
            doubleLinkedList3333.displayList();
            Console.WriteLine("\t\tSize of names3 : " + doubleLinkedList3333.Size);

            Console.Write("Elements of names4 -> ");
            doubleLinkedList4444.displayList();
            Console.WriteLine("\t\tSize of names4 : " + doubleLinkedList4444.Size);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
