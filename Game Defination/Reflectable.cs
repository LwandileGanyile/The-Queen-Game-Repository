using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Defination
{
    public interface Reflectable<T>
    {
        T reflectAroundEqualAxis(List<int> axisIndeces,int numberOfTimes);
    }
}
