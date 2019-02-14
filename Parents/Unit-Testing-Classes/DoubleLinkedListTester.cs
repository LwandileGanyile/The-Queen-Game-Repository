using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResources.Unit_Testing_Classes
{
    public class DoubleLinkedListTester
    {
        private DoubleLinkedList<int> list1;
        private DoubleLinkedList<string> list2;
        private DoubleLinkedList<char> list3;
        private DoubleLinkedList<int[]> list4;

        public DoubleLinkedListTester()
        {
            list1 = new DoubleLinkedList<int>();
            list2 = new DoubleLinkedList<string>();
            list3 = new DoubleLinkedList<char>();
            list4 = new DoubleLinkedList<int[]>();

            AddNumbers(list1);
            AddWords(list2);
            AddAlphabets(list3);
            AddLists(list4);

            Console.Write("Display initial list of numbers :");
            DisplayNumbers(list1);
            Console.Write("\nDisplay initial list of words :");
            DisplayWords(list2);
            Console.Write("\nDisplay initial list of alphabets :");
            DisplayAlphabets(list3);
            Console.Write("\nDisplay initial list of lists :");
            DisplayLists(list4);



            // Test RemoveFirst
            TestRemoveFirst(list1);
            TestRemoveFirst(list2);
            TestRemoveFirst(list3);
            TestRemoveFirst(list4);

            Console.WriteLine();
            Console.WriteLine("***********************RemoveFirst***********************");
            Console.WriteLine();

            Console.Write("\nTest the Remove First method on numbers :");
            DisplayNumbers(list1);
            Console.Write("\nTest the Remove First method on words :");
            DisplayWords(list2);
            Console.Write("\nTest the Remove First method on alphabets :");
            DisplayAlphabets(list3);
            Console.Write("\nTest the Remove First method on lists :");
            DisplayLists(list4);

            // Test RemoveFirst
            TestRemoveLast(list1);
            TestRemoveLast(list2);
            TestRemoveLast(list3);
            TestRemoveLast(list4);

            Console.WriteLine();
            Console.WriteLine("***********************RemoveLast***********************");
            Console.WriteLine();

            Console.Write("\nTest the Remove Last method on numbers :");
            DisplayNumbers(list1);
            Console.Write("\nTest the Remove Last method on words :");
            DisplayWords(list2);
            Console.Write("\nTest the Remove Last method on alphabets :");
            DisplayAlphabets(list3);
            Console.Write("\nTest the Remove Last method on lists :");
            DisplayLists(list4);

            // Test RemoveFirst
            TestRemoveAt(list1, 1);
            //TestRemoveAt(list2, 2);
            TestRemoveAt(list3, 3);
            TestRemoveAt(list4, 4);

            Console.WriteLine();
            Console.WriteLine("***********************RemoveAt***********************");
            Console.WriteLine();

            Console.Write("\nTest the Remove  At 1 method on numbers :");
            DisplayNumbers(list1);
            Console.Write("\nTest the Remove At 2 method on words :");
            DisplayWords(list2);
            Console.Write("\nTest the Remove At 3  method on alphabets :");
            DisplayAlphabets(list3);
            Console.Write("\nTest the Remove At 4 method on lists :");
            DisplayLists(list4);

            // Test AddLast
            AddLast(list1);
            AddLast(list2);
            AddLast(list3);
            AddLast(list4);

            Console.WriteLine();
            Console.WriteLine("***********************AddLast***********************");
            Console.WriteLine();

            Console.Write("\nTest the Add Last method on numbers :");
            DisplayNumbers(list1);
            Console.Write("\nTest the Add Last method on words :");
            DisplayWords(list2);
            Console.Write("\nTest the Add Last method on alphabets :");
            DisplayAlphabets(list3);
            Console.Write("\nTest the Add Last method on lists :");
            DisplayLists(list4);

            // Test AddFirst
            AddFirst(list1);
            AddFirst(list2);
            AddFirst(list3);
            AddFirst(list4);

            Console.WriteLine();
            Console.WriteLine("***********************AddFirst***********************");
            Console.WriteLine();

            Console.Write("\nTest the Add First method on numbers :");
            DisplayNumbers(list1);
            Console.Write("\nTest the Add First method on words :");
            DisplayWords(list2);
            Console.Write("\nTest the Add First method on alphabets :");
            DisplayAlphabets(list3);
            Console.Write("\nTest the Add First method on lists :");
            DisplayLists(list4);
        }


        // Testing the Add method.
        private void AddNumbers(DoubleLinkedList<int> list)
        {
            for (int i = 1; i < 10; i++)
                list.Add(i);
        }

        private void AddWords(DoubleLinkedList<string> list)
        {
            list.Add("Ndumiso Chamane");
            list.Add("Mfundo Mkhize");
            list.Add("Ntuthuko Cele");
            list.Add("Njabulo Khuzwayo");
        }

        private void AddAlphabets(DoubleLinkedList<char> list)
        {
            list.Add('$');
            list.Add('!');
            list.Add('_');
            list.Add(';');
            list.Add('*');
            list.Add('@');
            list.Add('_');
            list.Add('/');
        }

        private void AddLists(DoubleLinkedList<int[]> list)
        {
            list.Add(new int[] { 1,2,3,4,5});
            list.Add(new int[] { 2, 4, 6, 8, 10 });
            list.Add(new int[] { 3, 6, 9, 12, 15});
            list.Add(new int[] { 10,20,30,40,50});
        }


        // Testing the DispalyList method.
        private void DisplayNumbers(DoubleLinkedList<int> list)
        {
            /*for (int i = 0; i < list.Size; i++)
            {
                Console.WriteLine("------------------Digit number " + i + 1 + "-------------------");
                list.GetAt(i).ToString();
                Console.WriteLine();
            }*/
            list.DisplayList();
        }

        private void DisplayWords(DoubleLinkedList<string> list)
        {
            /*for (int i = 0; i < list.Size; i++)
            {
                Console.WriteLine("------------------Word number " + i + 1 + "-------------------");
                list.GetAt(i).ToString();
                Console.WriteLine();
            }*/
            list.DisplayList();
        }

        private void DisplayAlphabets(DoubleLinkedList<char> list)
        {
            /*for (int i = 0; i < list.Size; i++)
            {
                Console.WriteLine("------------------Character number " + i + 1 + "-------------------");
                list.GetAt(i).ToString();
                Console.WriteLine();
            }*/
            list.DisplayList();
        }

        private void DisplayLists(DoubleLinkedList<int[]> list)
        {
            /*for (int i = 0; i < list.Size; i++)
            {
                Console.WriteLine("------------------List number "+i+1+"-------------------");
                list.GetAt(i).ToString();
                Console.WriteLine();
            }*/
            list.DisplayList();
        }


        // Testing the RemoveFirst method.
        private void TestRemoveFirst(DoubleLinkedList<int[]> list)
        {
            list.RemoveFirst();
        }

        private void TestRemoveFirst(DoubleLinkedList<int> list)
        {
            list.RemoveFirst();
        }

        private void TestRemoveFirst(DoubleLinkedList<char> list)
        {
            list.RemoveFirst();
        }

        private void TestRemoveFirst(DoubleLinkedList<string> list)
        {
            list.RemoveFirst();
        }


        // Testing the RemoveLast method.
        private void TestRemoveLast(DoubleLinkedList<int[]> list)
        {
            list.RemoveLast();
        }

        private void TestRemoveLast(DoubleLinkedList<char> list)
        {
            list.RemoveLast();
        }

        private void TestRemoveLast(DoubleLinkedList<string> list)
        {
            list.RemoveLast();
        }

        private void TestRemoveLast(DoubleLinkedList<int> list)
        {
            list.RemoveLast();
        }



        // Testing the RemoveAt method.
        private void TestRemoveAt(DoubleLinkedList<int> list, int index)
        {
            list.Remove(index);
        }

        private void TestRemoveAt(DoubleLinkedList<char> list, int index)
        {
            list.Remove(index);
        }

        private void TestRemovAt(DoubleLinkedList<string> list, int index)
        {
            list.Remove(index);
        }

        private void TestRemoveAt(DoubleLinkedList<int[]> list, int index)
        {
            list.Remove(index);
        }

        // Testing the AddFirst method.
        private void AddFirst(DoubleLinkedList<int> list)
        {

            list.AddFirst(100000);
        }

        private void AddFirst(DoubleLinkedList<string> list)
        {
            list.AddFirst("George Nonyana");

        }

        private void AddFirst(DoubleLinkedList<char> list)
        {
            list.AddFirst(')');

        }

        private void AddFirst(DoubleLinkedList<int[]> list)
        {
            list.AddFirst(new int[] { 0, 0, 0 });

        }

        // Testing the AddLast method.
        private void AddLast(DoubleLinkedList<int> list)
        {

            list.AddLast(1000);
        }

        private void AddLast(DoubleLinkedList<string> list)
        {
            list.AddLast("Jomo Sono");

        }

        private void AddLast(DoubleLinkedList<char> list)
        {
            list.AddLast('-');

        }

        private void AddLast(DoubleLinkedList<int[]> list)
        {
            list.AddLast(new int[] { -30, 20, 10,90, -40, -30 });

        }
    }
}
