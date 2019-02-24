using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace Tertiary_Queen
{
    public interface IManyPlanes : IRotate<R3Plane>, IReflect<R3Plane>, IReflectable<R3Plane>, IFillPlane
    {
        



    }
}
