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
            Console.WriteLine("Remove first on list1 " + doubleLinkedList11.RemoveFirst());
            Console.WriteLine("Remove first on list2 " + doubleLinkedList22.RemoveFirst());
            Console.WriteLine("Remove first on list3 " + doubleLinkedList33.RemoveFirst());
            Console.WriteLine("Remove first on list4 " + doubleLinkedList44.RemoveFirst());

            Console.WriteLine();

            Console.WriteLine("Remove first on chars1 " + doubleLinkedList111.RemoveFirst());
            Console.WriteLine("Remove first on chars2 " + doubleLinkedList222.RemoveFirst());
            Console.WriteLine("Remove first on chars3 " + doubleLinkedList333.RemoveFirst());
            Console.WriteLine("Remove first on chars4 " + doubleLinkedList444.RemoveFirst());

            Console.WriteLine();

            Console.WriteLine("Remove first on names1 " + doubleLinkedList1111.RemoveFirst());
            Console.WriteLine("Remove first on names2 " + doubleLinkedList2222.RemoveFirst());
            Console.WriteLine("Remove first on names3 " + doubleLinkedList3333.RemoveFirst());
            Console.WriteLine("Remove first on names4 " + doubleLinkedList4444.RemoveFirst());

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------removeAt(index)------------------------------");
            Console.WriteLine("Remove element at '4' on list1, " + doubleLinkedList11.Remove(4) + " removed.");
            Console.WriteLine("Remove element at '2' on list2, " + doubleLinkedList22.Remove(2) + " removed.");
            Console.WriteLine("Remove element at '3' on list3, " + doubleLinkedList33.Remove(3) + " removed.");
            Console.WriteLine("Remove element at '1' on list4, " + doubleLinkedList44.Remove(1) + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove element at '1' on chars1, " + doubleLinkedList111.Remove(1) + " removed.");
            Console.WriteLine("Remove element at '2' on chars2, " + doubleLinkedList222.Remove(2) + " removed.");
            Console.WriteLine("Remove element at '3' on chars3, " + doubleLinkedList333.Remove(3) + " removed.");
            Console.WriteLine("Remove element at '4' on chars4, " + doubleLinkedList444.Remove(4) + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove element at '3' on names1, " + doubleLinkedList1111.Remove(3) + " removed.");
            Console.WriteLine("Remove element at '2' on names2, " + doubleLinkedList2222.Remove(2) + " removed.");
            Console.WriteLine("Remove element at '4' on names3, " + doubleLinkedList3333.Remove(4) + " removed.");
            Console.WriteLine("Remove element at '0' on names4, " + doubleLinkedList4444.Remove(0) + " removed.");

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------removeLast()------------------------------");
            Console.WriteLine("Remove last on list1, " + doubleLinkedList11.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on list2, " + doubleLinkedList22.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on list3, " + doubleLinkedList33.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on list4, " + doubleLinkedList44.RemoveLast() + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove last on chars1, " + doubleLinkedList111.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on chars2, " + doubleLinkedList222.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on chars3, " + doubleLinkedList333.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on chars4, " + doubleLinkedList444.RemoveLast() + " removed.");


            Console.WriteLine();

            Console.WriteLine("Remove last on names1, " + doubleLinkedList1111.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on names2, " + doubleLinkedList2222.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on names3, " + doubleLinkedList3333.RemoveLast() + " removed.");
            Console.WriteLine("Remove last on names4, " + doubleLinkedList4444.RemoveLast() + " removed.");

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
            doubleLinkedList11.AddFirst(23);
            Console.WriteLine("Add first '35'  of list2 ");
            doubleLinkedList22.AddFirst(35);
            Console.WriteLine("Add first '76'  of list3 ");
            doubleLinkedList33.AddFirst(76);
            Console.WriteLine("Add first '102'  of list4 ");
            doubleLinkedList44.AddFirst(102);

            Console.WriteLine();

            Console.WriteLine("Add first 'i' on chars1 ");
            doubleLinkedList111.AddFirst('i');
            Console.WriteLine("Add first 'r' on chars2 ");
            doubleLinkedList222.AddFirst('r');
            Console.WriteLine("Add first 'e' on chars3 ");
            doubleLinkedList333.AddFirst('e');
            Console.WriteLine("Add first 'w' on chars4 ");
            doubleLinkedList444.AddFirst('w');

            Console.WriteLine();

            Console.WriteLine("Add first 'Justin' on names1 ");
            doubleLinkedList1111.AddFirst("Justin");
            Console.WriteLine("Add first 'Melvin' on names2 ");
            doubleLinkedList2222.AddFirst("Melvin");
            Console.WriteLine("Add first 'Kalen' on names3 ");
            doubleLinkedList3333.AddFirst("Kalen");
            Console.WriteLine("Add first 'Tu' on names4 ");
            doubleLinkedList4444.AddFirst("Tu");

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------addAt(E element,3)------------------------------");
            Console.WriteLine("Add '1000' at '3' on list1 ");
            doubleLinkedList11.Add(1000, 3);
            Console.WriteLine("Add '2000' at '4' on list2 ");
            doubleLinkedList22.Add(2000, 4);
            Console.WriteLine("Add '5000' at '0' on list3 ");
            doubleLinkedList33.Add(5000, 0);
            Console.WriteLine("Add '20200' at '2' on list4 ");
            doubleLinkedList44.Add(20200, 2);

            Console.WriteLine();

            Console.WriteLine("Add 'f' at '0' on chars1 ");
            doubleLinkedList111.Add('f', 0);
            Console.WriteLine("Add 's' at '2' on chars2 ");
            doubleLinkedList222.Add('s', 2);
            Console.WriteLine("Add 'q' at '4' on chars3 ");
            doubleLinkedList333.Add('q', 4);
            Console.WriteLine("Add 'm' at '6' on chars4 ");
            doubleLinkedList444.Add('m', 6);

            Console.WriteLine();

            Console.WriteLine("Add 'Nolwazi' at '4' on names1 ");
            doubleLinkedList1111.Add("Nolwazi", 4);
            Console.WriteLine("Add 'Lizwi' at '3' on names2 ");
            doubleLinkedList2222.Add("Lizwi", 3);
            Console.WriteLine("Add 'Scelo' at '7' on names3 ");
            doubleLinkedList3333.Add("Scelo", 7);
            Console.WriteLine("Add 'Cebo' at '0' on names4 ");
            doubleLinkedList4444.Add("Cebo", 0);

            Console.WriteLine();

            print();

            Console.WriteLine();

            Console.WriteLine("----------------addLast(T element)------------------------------");
            Console.WriteLine("Add last '4' on list1 ");
            doubleLinkedList11.AddLast(4);
            Console.WriteLine("Add last '5' on list2 ");
            doubleLinkedList22.AddLast(5);
            Console.WriteLine("Add last '6' on list3 ");
            doubleLinkedList33.AddLast(6);
            Console.WriteLine("Add last '7' of list4 ");
            doubleLinkedList44.AddLast(7);

            Console.WriteLine();

            Console.WriteLine("Add last 'k' on chars1 ");
            doubleLinkedList111.AddLast('k');
            Console.WriteLine("Add last 'i' on chars2 ");
            doubleLinkedList222.AddLast('i');
            Console.WriteLine("Add last 't' on chars3 ");
            doubleLinkedList333.AddLast('t');
            Console.WriteLine("Add last 'x' on chars4 ");
            doubleLinkedList444.AddLast('x');

            Console.WriteLine();

            Console.WriteLine("Add last 'Wendy' on names1 ");
            doubleLinkedList1111.AddLast("Wendy");
            Console.WriteLine("Add last 'Anele' on names2 ");
            doubleLinkedList2222.AddLast("Anele");
            Console.WriteLine("Add last 'Samke' on names3 ");
            doubleLinkedList3333.AddLast("Samke");
            Console.WriteLine("Add last 'Anathi' on names4 ");
            doubleLinkedList4444.AddLast("Anathi");

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
            Console.WriteLine("First value of list1 " + doubleLinkedList11.GetFirst());
            Console.WriteLine("First value of list2 " + doubleLinkedList22.GetFirst());
            Console.WriteLine("First value of list3 " + doubleLinkedList33.GetFirst());
            Console.WriteLine("First value of list4 " + doubleLinkedList44.GetFirst());

            Console.WriteLine();

            Console.WriteLine("First value of chars1 " + doubleLinkedList111.GetFirst());
            Console.WriteLine("First value of chars2 " + doubleLinkedList222.GetFirst());
            Console.WriteLine("First value of chars3 " + doubleLinkedList333.GetFirst());
            Console.WriteLine("First value of chars4 " + doubleLinkedList444.GetFirst());

            Console.WriteLine();

            Console.WriteLine("First value of names1 " + doubleLinkedList1111.GetFirst());
            Console.WriteLine("First value of names2 " + doubleLinkedList2222.GetFirst());
            Console.WriteLine("First value of names3 " + doubleLinkedList3333.GetFirst());
            Console.WriteLine("First value of names4 " + doubleLinkedList4444.GetFirst());

            Console.WriteLine();

            Console.WriteLine("----------------getAt(3)------------------------------");
            Console.WriteLine("At value of list1 " + doubleLinkedList11.GetAt(3));
            Console.WriteLine("At value of list2 " + doubleLinkedList22.GetAt(3));
            Console.WriteLine("At value of list3 " + doubleLinkedList33.GetAt(3));
            Console.WriteLine("At value of list4 " + doubleLinkedList44.GetAt(3));

            Console.WriteLine();

            Console.WriteLine("At value of chars1 " + doubleLinkedList111.GetAt(3));
            Console.WriteLine("At value of chars2 " + doubleLinkedList222.GetAt(3));
            Console.WriteLine("At value of chars3 " + doubleLinkedList333.GetAt(3));
            Console.WriteLine("At value of chars4 " + doubleLinkedList444.GetAt(3));

            Console.WriteLine();

            Console.WriteLine("At value of names1 " + doubleLinkedList1111.GetAt(3));
            Console.WriteLine("At value of names2 " + doubleLinkedList2222.GetAt(3));
            Console.WriteLine("At value of names3 " + doubleLinkedList3333.GetAt(3));
            Console.WriteLine("At value of names4 " + doubleLinkedList4444.GetAt(3));

            Console.WriteLine();

            Console.WriteLine("----------------getLast()------------------------------");
            Console.WriteLine("Last value of list1 " + doubleLinkedList11.GetLast());
            Console.WriteLine("Last value of list2 " + doubleLinkedList22.GetLast());
            Console.WriteLine("Last value of list3 " + doubleLinkedList33.GetLast());
            Console.WriteLine("Last value of list4 " + doubleLinkedList44.GetLast());

            Console.WriteLine();

            Console.WriteLine("Last value of chars1 " + doubleLinkedList111.GetLast());
            Console.WriteLine("Last value of chars2 " + doubleLinkedList222.GetLast());
            Console.WriteLine("Last value of chars3 " + doubleLinkedList333.GetLast());
            Console.WriteLine("Last value of chars4 " + doubleLinkedList444.GetLast());

            Console.WriteLine();

            Console.WriteLine("Last value of names1 " + doubleLinkedList1111.GetLast());
            Console.WriteLine("Last value of names2 " + doubleLinkedList2222.GetLast());
            Console.WriteLine("Last value of names3 " + doubleLinkedList3333.GetLast());
            Console.WriteLine("Last value of names4 " + doubleLinkedList4444.GetLast());

            Console.WriteLine();


            print();
        }

        public void print()
        {

            Console.WriteLine("-----List Elements------&-----Size Property------------------------------");
            Console.Write("Elements of list1 -> ");
            doubleLinkedList11.DisplayList();
            Console.WriteLine("\t\tSize of list1 :" + doubleLinkedList11.Size);

            Console.Write("Elements of list2 -> ");
            doubleLinkedList22.DisplayList();
            Console.WriteLine("\t\tSize of list2 : " + doubleLinkedList22.Size);

            Console.Write("Elements of list3 -> ");
            doubleLinkedList33.DisplayList();
            Console.WriteLine("\t\tSize of list3 : " + doubleLinkedList33.Size);

            Console.Write("Elements of list4 -> ");
            doubleLinkedList44.DisplayList();
            Console.WriteLine("\t\tSize of list4 : " + doubleLinkedList44.Size);

            Console.WriteLine();

            Console.Write("Elements of chars1 -> ");
            doubleLinkedList111.DisplayList();
            Console.WriteLine("\t\tSize of chars1 : " + doubleLinkedList111.Size);

            Console.Write("Elements of chars2 -> ");
            doubleLinkedList222.DisplayList();
            Console.WriteLine("\t\tSize of chars2 : " + doubleLinkedList222.Size);

            Console.Write("Elements of chars3 -> ");
            doubleLinkedList333.DisplayList();
            Console.WriteLine("\t\tSize of chars3 : " + doubleLinkedList333.Size);

            Console.Write("Elements of chars4 -> ");
            doubleLinkedList444.DisplayList();
            Console.WriteLine("\t\tSize of chars4 : " + doubleLinkedList444.Size);
            Console.WriteLine();

            Console.Write("Elements of names1 -> ");
            doubleLinkedList1111.DisplayList();
            Console.WriteLine("\t\tSize of names1 : " + doubleLinkedList1111.Size);

            Console.Write("Elements of names2 -> ");
            doubleLinkedList2222.DisplayList();
            Console.WriteLine();
            Console.WriteLine("\t\tSize of names2 : " + doubleLinkedList2222.Size);

            Console.Write("Elements of names3 -> ");
            doubleLinkedList3333.DisplayList();
            Console.WriteLine("\t\tSize of names3 : " + doubleLinkedList3333.Size);

            Console.Write("Elements of names4 -> ");
            doubleLinkedList4444.DisplayList();
            Console.WriteLine("\t\tSize of names4 : " + doubleLinkedList4444.Size);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
