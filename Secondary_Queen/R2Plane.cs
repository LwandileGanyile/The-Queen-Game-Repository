using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
namespace Secondary_Queen
{
    public class R2Plane:Plane
    {
        private static R2Plane plane = null;

        private R2Plane()
        {
            planeNumber = 1;
            planeDimension = 2;
            planeCentre = new R2Point().Position;
            isR2Plane = false;
            FillDirections();
   
        }
  

        public static R2Plane GetR2Plane()
        {
            

            if (plane == null)
            {
                plane = new R2Plane();
                return plane;
            }
            else
                return plane;
        }

        public override void FillDirections()
        {

            directions.Add(6);
            directions.Add(2);
            directions.Add(4);
            directions.Add(1);
            directions.Add(7);
            directions.Add(3);
            directions.Add(5);
            directions.Add(8);
        }

        // I'm not sure what is better than the other, between returning plane and returning this.
        public override Plane ReflectAboutAxis(int axisIndex)
        {
            return GetR2Plane();
        }

        // I'm not sure what is better than the other, between returning plane and returning this.
        public override Plane RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            return GetR2Plane();
        }

        // I'm not sure what is better than the other, between returning plane and returning this.
        public override Plane ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            return plane;
        }
    }
}
