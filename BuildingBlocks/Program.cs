using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
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


            CircularLinkedList<int> circularLinkedList11 = new CircularLinkedList<int>(list1);
            CircularLinkedList<int> circularLinkedList22 = new CircularLinkedList<int>(list2);
            CircularLinkedList<int> circularLinkedList33 = new CircularLinkedList<int>(list3);
            CircularLinkedList<int> circularLinkedList44 = new CircularLinkedList<int>(list4);

            CircularLinkedList<char> circularLinkedList111 = new CircularLinkedList<char>(chars1);
            CircularLinkedList<char> circularLinkedList222 = new CircularLinkedList<char>(chars2);
            CircularLinkedList<char> circularLinkedList333 = new CircularLinkedList<char>(chars3);
            CircularLinkedList<char> circularLinkedList444 = new CircularLinkedList<char>(chars4);

            CircularLinkedList<string> circularLinkedList1111 = new CircularLinkedList<string>(names1);
            CircularLinkedList<string> circularLinkedList2222 = new CircularLinkedList<string>(names2);
            CircularLinkedList<string> circularLinkedList3333 = new CircularLinkedList<string>(names3);
            CircularLinkedList<string> circularLinkedList4444 = new CircularLinkedList<string>(names4);


            testRemoveMethods(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine("Building Blocks Main" );
            Console.ReadLine();
        }

        private static void testDoubleLinkedList()
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

            DoubleLinkedList<int> doubleLinkedList111 = new DoubleLinkedList<int>(list1);
            DoubleLinkedList<int> doubleLinkedList222 = new DoubleLinkedList<int>(list2);
            DoubleLinkedList<int> doubleLinkedList333 = new DoubleLinkedList<int>(list3);
            DoubleLinkedList<int> doubleLinkedList444 = new DoubleLinkedList<int>(list4);

            DoubleLinkedList<char> doubleLinkedList11 = new DoubleLinkedList<char>(chars1);
            DoubleLinkedList<char> doubleLinkedList22 = new DoubleLinkedList<char>(chars2);
            DoubleLinkedList<char> doubleLinkedList33 = new DoubleLinkedList<char>(chars3);
            DoubleLinkedList<char> doubleLinkedList44 = new DoubleLinkedList<char>(chars4);

            DoubleLinkedList<string> doubleLinkedList1 = new DoubleLinkedList<string>(names1);
            DoubleLinkedList<string> doubleLinkedList2 = new DoubleLinkedList<string>(names2);
            DoubleLinkedList<string> doubleLinkedList3 = new DoubleLinkedList<string>(names3);
            DoubleLinkedList<string> doubleLinkedList4 = new DoubleLinkedList<string>(names4);

            Console.WriteLine("-----------------------------Testing getFirst() & getLast on the Double linked list class-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------getFirst()------------------------------");
            Console.WriteLine("First value of list1 " + doubleLinkedList111.getFirst());
            Console.WriteLine("First value of list2 " + doubleLinkedList222.getFirst());
            Console.WriteLine("First value of list3 " + doubleLinkedList333.getFirst());
            Console.WriteLine("First value of list4 " + doubleLinkedList444.getFirst());
            Console.WriteLine("First value of chars1 " + doubleLinkedList11.getFirst());
            Console.WriteLine("First value of chars2 " + doubleLinkedList22.getFirst());
            Console.WriteLine("First value of chars3 " + doubleLinkedList33.getFirst());
            Console.WriteLine("First value of chars4 " + doubleLinkedList44.getFirst());
            Console.WriteLine("First value of names1 " + doubleLinkedList1.getLast());
            Console.WriteLine("First value of names2 " + doubleLinkedList2.getLast());
            Console.WriteLine("First value of names3 " + doubleLinkedList3.getLast());
            Console.WriteLine("First value of names4 " + doubleLinkedList4.getLast());
            Console.WriteLine();
            Console.WriteLine("----------------getAt(int index)------------------------------");
            Console.WriteLine("Forth value of list1 " + doubleLinkedList111.getAt(3));
            Console.WriteLine("Forth value of list2 " + doubleLinkedList222.getAt(3));
            Console.WriteLine("Forth value of list3 " + doubleLinkedList333.getAt(3));
            Console.WriteLine("Forth value of list4 " + doubleLinkedList444.getAt(3));
            Console.WriteLine("Forth value of chars1 " + doubleLinkedList11.getAt(3));
            Console.WriteLine("Forth value of chars2 " + doubleLinkedList22.getAt(3));
            Console.WriteLine("Forth value of chars3 " + doubleLinkedList33.getAt(3));
            Console.WriteLine("Forth value of chars4 " + doubleLinkedList44.getAt(3));
            Console.WriteLine("Forth value of names1 " + doubleLinkedList1.getAt(3));
            Console.WriteLine("Forth value of names2 " + doubleLinkedList2.getAt(3));
            Console.WriteLine("Forth value of names3 " + doubleLinkedList3.getAt(3));
            Console.WriteLine("Forth value of names4 " + doubleLinkedList4.getAt(3));
            Console.WriteLine();
            Console.WriteLine("----------------getLast()------------------------------");
            Console.WriteLine("Last value of list1 " + doubleLinkedList111.getLast());
            Console.WriteLine("Last value of list2 " + doubleLinkedList222.getLast());
            Console.WriteLine("Last value of list3 " + doubleLinkedList333.getLast());
            Console.WriteLine("Last value of list4 " + doubleLinkedList444.getLast());
            Console.WriteLine("Last value of chars1 " + doubleLinkedList11.getLast());
            Console.WriteLine("Last value of chars2 " + doubleLinkedList22.getLast());
            Console.WriteLine("Last value of chars3 " + doubleLinkedList33.getLast());
            Console.WriteLine("Last value of chars4 " + doubleLinkedList44.getLast());
            Console.WriteLine("Last value of names1 " + doubleLinkedList1.getLast());
            Console.WriteLine("Last value of names2 " + doubleLinkedList2.getLast());
            Console.WriteLine("Last value of names3 " + doubleLinkedList3.getLast());
            Console.WriteLine("Last value of names4 " + doubleLinkedList4.getLast());
            Console.WriteLine();
            Console.WriteLine("----------------Size Property------------------------------");
            Console.WriteLine("Size of list1 " + doubleLinkedList111.Size);
            Console.WriteLine("Size of list2 " + doubleLinkedList222.Size);
            Console.WriteLine("Size of list3 " + doubleLinkedList333.Size);
            Console.WriteLine("Size of list4 " + doubleLinkedList444.Size);
            Console.WriteLine("Size of chars1 " + doubleLinkedList11.Size);
            Console.WriteLine("Size of chars2 " + doubleLinkedList22.Size);
            Console.WriteLine("Size of chars3 " + doubleLinkedList33.Size);
            Console.WriteLine("Size of chars4 " + doubleLinkedList44.Size);
            Console.WriteLine("Size of names1 " + doubleLinkedList1.Size);
            Console.WriteLine("Size of names2 " + doubleLinkedList2.Size);
            Console.WriteLine("Size of names3 " + doubleLinkedList3.Size);
            Console.WriteLine("Size of names4 " + doubleLinkedList4.Size);
            Console.WriteLine();
        }

        private static void testCircularLinkedList(CircularLinkedList<int> circularLinkedList11, CircularLinkedList<int> circularLinkedList22,
         CircularLinkedList<int> circularLinkedList33, CircularLinkedList<int> circularLinkedList44,
         CircularLinkedList<char> circularLinkedList111, CircularLinkedList<char> circularLinkedList222,
         CircularLinkedList<char> circularLinkedList333, CircularLinkedList<char> circularLinkedList444,
         CircularLinkedList<string> circularLinkedList1111, CircularLinkedList<string> circularLinkedList2222,
         CircularLinkedList<string> circularLinkedList3333, CircularLinkedList<string> circularLinkedList4444)
        {
            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            testGetMethods(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            testAddMethods(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            testRemoveMethods(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

        }

        private static void testRemoveMethods(CircularLinkedList<int> circularLinkedList11, CircularLinkedList<int> circularLinkedList22,
         CircularLinkedList<int> circularLinkedList33, CircularLinkedList<int> circularLinkedList44,
         CircularLinkedList<char> circularLinkedList111, CircularLinkedList<char> circularLinkedList222,
         CircularLinkedList<char> circularLinkedList333, CircularLinkedList<char> circularLinkedList444,
         CircularLinkedList<string> circularLinkedList1111, CircularLinkedList<string> circularLinkedList2222,
         CircularLinkedList<string> circularLinkedList3333, CircularLinkedList<string> circularLinkedList4444)
        {
            Console.WriteLine("----------Testing  removeFirst(), removeAt(int index) & removeLast() on the Circular linked list class--------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------removeFirst()------------------------------");
            Console.WriteLine("Remove first on list1 "+ circularLinkedList11.removeFirst());
            Console.WriteLine("Remove first on list2 " + circularLinkedList22.removeFirst());
            Console.WriteLine("Remove first on list3 " + circularLinkedList33.removeFirst());
            Console.WriteLine("Remove first on list4 " + circularLinkedList44.removeFirst());

            Console.WriteLine();

            Console.WriteLine("Remove first on chars1 " + circularLinkedList111.removeFirst());
            Console.WriteLine("Remove first on chars2 " + circularLinkedList222.removeFirst());
            Console.WriteLine("Remove first on chars3 " + circularLinkedList333.removeFirst());
            Console.WriteLine("Remove first on chars4 " + circularLinkedList444.removeFirst());

            Console.WriteLine();

            Console.WriteLine("Remove first on names1 " + circularLinkedList1111.removeFirst());
            Console.WriteLine("Remove first on names2 " + circularLinkedList2222.removeFirst());
            Console.WriteLine("Remove first on names3 " + circularLinkedList3333.removeFirst());
            Console.WriteLine("Remove first on names4 " + circularLinkedList4444.removeFirst());

            Console.WriteLine();

            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine();

            Console.WriteLine("----------------removeAt(index)------------------------------");
            Console.WriteLine("Remove element at '4' on list1, " + circularLinkedList11.remove(4) + " removed.");
            Console.WriteLine("Remove element at '2' on list2, " + circularLinkedList22.remove(2) + " removed.");
            Console.WriteLine("Remove element at '3' on list3, " + circularLinkedList33.remove(3) + " removed.");
            Console.WriteLine("Remove element at '1' on list4, " + circularLinkedList44.remove(1) + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove element at '1' on chars1, " + circularLinkedList111.remove(1) + " removed.");
            Console.WriteLine("Remove element at '2' on chars2, " + circularLinkedList222.remove(2) + " removed.");
            Console.WriteLine("Remove element at '3' on chars3, " + circularLinkedList333.remove(3) + " removed.");
            Console.WriteLine("Remove element at '4' on chars4, " + circularLinkedList444.remove(4) + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove element at '3' on names1, " + circularLinkedList1111.remove(3) + " removed.");
            Console.WriteLine("Remove element at '2' on names2, " + circularLinkedList2222.remove(2) + " removed.");
            Console.WriteLine("Remove element at '4' on names3, " + circularLinkedList3333.remove(4) + " removed.");
            Console.WriteLine("Remove element at '0' on names4, " + circularLinkedList4444.remove(0) + " removed.");

            Console.WriteLine();

            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine();

            Console.WriteLine("----------------removeLast()------------------------------");
            Console.WriteLine("Remove last on list1, " + circularLinkedList11.removeLast() + " removed.");
            Console.WriteLine("Remove last on list2, " + circularLinkedList22.removeLast() + " removed.");
            Console.WriteLine("Remove last on list3, " + circularLinkedList33.removeLast() + " removed.");
            Console.WriteLine("Remove last on list4, " + circularLinkedList44.removeLast() + " removed.");

            Console.WriteLine();

            Console.WriteLine("Remove last on chars1, "+ circularLinkedList111.removeLast()+" removed.");
            Console.WriteLine("Remove last on chars2, "+ circularLinkedList222.removeLast() + " removed.");
            Console.WriteLine("Remove last on chars3, "+ circularLinkedList333.removeLast() + " removed.");
            Console.WriteLine("Remove last on chars4, "+ circularLinkedList444.removeLast() + " removed.");
            

            Console.WriteLine();

            Console.WriteLine("Remove last on names1, " + circularLinkedList1111.removeLast() + " removed.");
            Console.WriteLine("Remove last on names2, " + circularLinkedList2222.removeLast() + " removed.");
            Console.WriteLine("Remove last on names3, " + circularLinkedList3333.removeLast() + " removed.");
            Console.WriteLine("Remove last on names4, " + circularLinkedList4444.removeLast() + " removed.");

            Console.WriteLine();

            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine();
        }

        private static void testAddMethods(CircularLinkedList<int> circularLinkedList11, CircularLinkedList<int> circularLinkedList22,
         CircularLinkedList<int> circularLinkedList33, CircularLinkedList<int> circularLinkedList44,
         CircularLinkedList<char> circularLinkedList111, CircularLinkedList<char> circularLinkedList222,
         CircularLinkedList<char> circularLinkedList333, CircularLinkedList<char> circularLinkedList444,
         CircularLinkedList<string> circularLinkedList1111, CircularLinkedList<string> circularLinkedList2222,
         CircularLinkedList<string> circularLinkedList3333, CircularLinkedList<string> circularLinkedList4444)
        {
            Console.WriteLine("----------Testing  addFirst(), addAt(int index) & addLast() on the Circular linked list class--------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------addFirst()------------------------------");
            Console.WriteLine("Add first '23' of list1 ");
            circularLinkedList11.addFirst(23);
            Console.WriteLine("Add first '35'  of list2 ");
            circularLinkedList22.addFirst(35);
            Console.WriteLine("Add first '76'  of list3 ");
            circularLinkedList33.addFirst(76);
            Console.WriteLine("Add first '102'  of list4 ");
            circularLinkedList44.addFirst(102);

            Console.WriteLine();

            Console.WriteLine("Add first 'i' on chars1 ");
            circularLinkedList111.addFirst('i');
            Console.WriteLine("Add first 'r' on chars2 ");
            circularLinkedList222.addFirst('r');
            Console.WriteLine("Add first 'e' on chars3 ");
            circularLinkedList333.addFirst('e');
            Console.WriteLine("Add first 'w' on chars4 ");
            circularLinkedList444.addFirst('w');

            Console.WriteLine();

            Console.WriteLine("Add first 'Justin' on names1 ");
            circularLinkedList1111.addFirst("Justin");
            Console.WriteLine("Add first 'Melvin' on names2 ");
            circularLinkedList2222.addFirst("Melvin");
            Console.WriteLine("Add first 'Kalen' on names3 ");
            circularLinkedList3333.addFirst("Kalen");
            Console.WriteLine("Add first 'Tu' on names4 ");
            circularLinkedList4444.addFirst("Tu");

            Console.WriteLine();

            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine();

            Console.WriteLine("----------------addAt(E element,3)------------------------------");
            Console.WriteLine("Add '1000' at '3' on list1 ");
            circularLinkedList11.add(1000, 3);
            Console.WriteLine("Add '2000' at '4' on list2 ");
            circularLinkedList22.add(2000, 4);
            Console.WriteLine("Add '5000' at '0' on list3 ");
            circularLinkedList33.add(5000, 0);
            Console.WriteLine("Add '20200' at '2' on list4 ");
            circularLinkedList44.add(20200, 2);

            Console.WriteLine();

            Console.WriteLine("Add 'f' at '0' on chars1 ");
            circularLinkedList111.add('f', 0);
            Console.WriteLine("Add 's' at '2' on chars2 ");
            circularLinkedList222.add('s', 2);
            Console.WriteLine("Add 'q' at '4' on chars3 ");
            circularLinkedList333.add('q', 4);
            Console.WriteLine("Add 'm' at '6' on chars4 ");
            circularLinkedList444.add('m', 6);

            Console.WriteLine();

            Console.WriteLine("Add 'Nolwazi' at '4' on names1 ");
            circularLinkedList1111.add("Nolwazi", 4);
            Console.WriteLine("Add 'Lizwi' at '3' on names2 ");
            circularLinkedList2222.add("Lizwi", 3);
            Console.WriteLine("Add 'Scelo' at '7' on names3 ");
            circularLinkedList3333.add("Scelo", 7);
            Console.WriteLine("Add 'Cebo' at '0' on names4 ");
            circularLinkedList4444.add("Cebo", 0);

            Console.WriteLine();

            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine();

            Console.WriteLine("----------------addLast(T element)------------------------------");
            Console.WriteLine("Add last '4' on list1 ");
            circularLinkedList11.addLast(4);
            Console.WriteLine("Add last '5' on list2 ");
            circularLinkedList22.addLast(5);
            Console.WriteLine("Add last '6' on list3 ");
            circularLinkedList33.addLast(6);
            Console.WriteLine("Add last '7' of list4 ");
            circularLinkedList44.addLast(7);

            Console.WriteLine();

            Console.WriteLine("Add last 'k' on chars1 ");
            circularLinkedList111.addLast('k');
            Console.WriteLine("Add last 'i' on chars2 ");
            circularLinkedList222.addLast('i');
            Console.WriteLine("Add last 't' on chars3 ");
            circularLinkedList333.addLast('t');
            Console.WriteLine("Add last 'x' on chars4 ");
            circularLinkedList444.addLast('x');

            Console.WriteLine();

            Console.WriteLine("Add last 'Wendy' on names1 ");
            circularLinkedList1111.addLast("Wendy");
            Console.WriteLine("Add last 'Anele' on names2 ");
            circularLinkedList2222.addLast("Anele");
            Console.WriteLine("Add last 'Samke' on names3 ");
            circularLinkedList3333.addLast("Samke");
            Console.WriteLine("Add last 'Anathi' on names4 ");
            circularLinkedList4444.addLast("Anathi");

            Console.WriteLine();

            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);

            Console.WriteLine();
        }

        private static void testGetMethods(CircularLinkedList<int> circularLinkedList11, CircularLinkedList<int> circularLinkedList22,
         CircularLinkedList<int> circularLinkedList33, CircularLinkedList<int> circularLinkedList44,
         CircularLinkedList<char> circularLinkedList111, CircularLinkedList<char> circularLinkedList222,
         CircularLinkedList<char> circularLinkedList333, CircularLinkedList<char> circularLinkedList444,
         CircularLinkedList<string> circularLinkedList1111, CircularLinkedList<string> circularLinkedList2222,
         CircularLinkedList<string> circularLinkedList3333, CircularLinkedList<string> circularLinkedList4444)
        {
            Console.WriteLine("----------Testing  getFirst(), getAt(int index) & getLast() on the Circular linked list class--------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------getFirst()------------------------------");
            Console.WriteLine("First value of list1 " + circularLinkedList11.getFirst());
            Console.WriteLine("First value of list2 " + circularLinkedList22.getFirst());
            Console.WriteLine("First value of list3 " + circularLinkedList33.getFirst());
            Console.WriteLine("First value of list4 " + circularLinkedList44.getFirst());

            Console.WriteLine();

            Console.WriteLine("First value of chars1 " + circularLinkedList111.getFirst());
            Console.WriteLine("First value of chars2 " + circularLinkedList222.getFirst());
            Console.WriteLine("First value of chars3 " + circularLinkedList333.getFirst());
            Console.WriteLine("First value of chars4 " + circularLinkedList444.getFirst());

            Console.WriteLine();

            Console.WriteLine("First value of names1 " + circularLinkedList1111.getFirst());
            Console.WriteLine("First value of names2 " + circularLinkedList2222.getFirst());
            Console.WriteLine("First value of names3 " + circularLinkedList3333.getFirst());
            Console.WriteLine("First value of names4 " + circularLinkedList4444.getFirst());

            Console.WriteLine();

            Console.WriteLine("----------------getAt(3)------------------------------");
            Console.WriteLine("At value of list1 " + circularLinkedList11.getAt(3));
            Console.WriteLine("At value of list2 " + circularLinkedList22.getAt(3));
            Console.WriteLine("At value of list3 " + circularLinkedList33.getAt(3));
            Console.WriteLine("At value of list4 " + circularLinkedList44.getAt(3));

            Console.WriteLine();

            Console.WriteLine("At value of chars1 " + circularLinkedList111.getAt(3));
            Console.WriteLine("At value of chars2 " + circularLinkedList222.getAt(3));
            Console.WriteLine("At value of chars3 " + circularLinkedList333.getAt(3));
            Console.WriteLine("At value of chars4 " + circularLinkedList444.getAt(3));

            Console.WriteLine();

            Console.WriteLine("At value of names1 " + circularLinkedList1111.getAt(3));
            Console.WriteLine("At value of names2 " + circularLinkedList2222.getAt(3));
            Console.WriteLine("At value of names3 " + circularLinkedList3333.getAt(3));
            Console.WriteLine("At value of names4 " + circularLinkedList4444.getAt(3));

            Console.WriteLine();

            Console.WriteLine("----------------getLast()------------------------------");
            Console.WriteLine("Last value of list1 " + circularLinkedList11.getLast());
            Console.WriteLine("Last value of list2 " + circularLinkedList22.getLast());
            Console.WriteLine("Last value of list3 " + circularLinkedList33.getLast());
            Console.WriteLine("Last value of list4 " + circularLinkedList44.getLast());

            Console.WriteLine();

            Console.WriteLine("Last value of chars1 " + circularLinkedList111.getLast());
            Console.WriteLine("Last value of chars2 " + circularLinkedList222.getLast());
            Console.WriteLine("Last value of chars3 " + circularLinkedList333.getLast());
            Console.WriteLine("Last value of chars4 " + circularLinkedList444.getLast());

            Console.WriteLine();

            Console.WriteLine("Last value of names1 " + circularLinkedList1111.getLast());
            Console.WriteLine("Last value of names2 " + circularLinkedList2222.getLast());
            Console.WriteLine("Last value of names3 " + circularLinkedList3333.getLast());
            Console.WriteLine("Last value of names4 " + circularLinkedList4444.getLast());

            Console.WriteLine();


            print(circularLinkedList11, circularLinkedList22, circularLinkedList33, circularLinkedList44,
            circularLinkedList111, circularLinkedList222, circularLinkedList333, circularLinkedList444,
            circularLinkedList1111, circularLinkedList2222, circularLinkedList3333, circularLinkedList4444);
        }

        private static void print(CircularLinkedList<int> circularLinkedList11, CircularLinkedList<int> circularLinkedList22,
         CircularLinkedList<int> circularLinkedList33, CircularLinkedList<int> circularLinkedList44,
         CircularLinkedList<char> circularLinkedList111, CircularLinkedList<char> circularLinkedList222,
         CircularLinkedList<char> circularLinkedList333, CircularLinkedList<char> circularLinkedList444,
         CircularLinkedList<string> circularLinkedList1111, CircularLinkedList<string> circularLinkedList2222,
         CircularLinkedList<string> circularLinkedList3333, CircularLinkedList<string> circularLinkedList4444)
        {

            Console.WriteLine("-----List Elements------&-----Size Property------------------------------");
            Console.Write("Elements of list1 -> ");
            circularLinkedList11.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of list1 " + circularLinkedList11.Size);

            Console.Write("Elements of list2 -> ");
            circularLinkedList22.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of list2 " + circularLinkedList22.Size);

            Console.Write("Elements of list3 -> ");
            circularLinkedList33.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of list3 " + circularLinkedList33.Size);

            Console.Write("Elements of list4 -> ");
            circularLinkedList44.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of list4 " + circularLinkedList44.Size);

            Console.WriteLine();

            Console.Write("Elements of chars1 -> ");
            circularLinkedList111.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of chars1 " + circularLinkedList111.Size);

            Console.Write("Elements of chars2 -> ");
            circularLinkedList222.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of chars2 " + circularLinkedList222.Size);

            Console.Write("Elements of chars3 -> ");
            circularLinkedList333.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of chars3 " + circularLinkedList333.Size);

            Console.Write("Elements of chars4 -> ");
            circularLinkedList444.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of chars4 " + circularLinkedList444.Size);
            Console.WriteLine();

            Console.Write("Elements of names1 -> ");
            circularLinkedList1111.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of names1 " + circularLinkedList1111.Size);

            Console.Write("Elements of names2 -> ");
            circularLinkedList2222.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of names2 " + circularLinkedList2222.Size);

            Console.Write("Elements of names3 -> ");
            circularLinkedList3333.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of names3 " + circularLinkedList3333.Size);

            Console.Write("Elements of names4 -> ");
            circularLinkedList4444.displayList();
            Console.WriteLine();
            Console.WriteLine("Size of names4 " + circularLinkedList4444.Size);

            Console.WriteLine();
            Console.WriteLine();
        }
    }

    
}
