using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Unit_Testing_Classes
{
    public class CircularTester
    {
        List<int> list1 = new List<int> { 321, 342, 332, 114, 512, 142, 4432, 121 };
        List<int> list2 = new List<int> { 3221, 3342, 3232, 1211, 3212, 1142, 4432, 1321, 1214, 3212, 1142 };
        List<int> list3 = new List<int> { 32451, 39842, 33232, 13214, 32112, 142, 44032, 12100, 39242, 33212, 13214 };

        List<char> chars1 = new List<char> { ';', 'z', 't', '@', 'q', '[', '@', 'q', '*' };
        List<char> chars2 = new List<char> { 'd', 'z', 't', '[', '@', 'q', '*', ';', 'z', 't' };
        List<char> chars3 = new List<char> { '}', '[', '@', 'q', 'd', 'z', 't', '[', '@', 'q', '*', 'd', 'z' };

        List<string> names1 = new List<string> { "Amanda", "Lwandiso", "Bonani", "", "Snothi" };
        List<string> names2 = new List<string> { "Endi", "Jacob", "Asiphe", "Esethu", "Amanda", "Lwandiso", "Menzi", "", "Snothi" };
        List<string> names3 = new List<string> { "Bonani", "", "Snothi", "Lwandiso", "Menzi", "Amanda", "Lwandiso", "Bonani", "", "Snothi" };
    }
}
