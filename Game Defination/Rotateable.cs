using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Defination
{
    public interface Rotateable<T>
    {
        T rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes);
    }
}
