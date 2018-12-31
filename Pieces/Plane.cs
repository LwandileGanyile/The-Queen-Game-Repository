using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace Pieces
{
    public abstract class Plane : Reflectable<Plane>, Rotateable<Plane>, IReflect<Plane>, IRotate<Plane>
    {
        protected int planeDimension;
        protected int planeNumber;
        protected Point planeCentre;
        protected List<int> directions;

        protected Plane()
        {

        }

        protected Plane(Point planeCentre, int planeDimension, int planeNumber)
        {

        }

        public bool areDirectionsOnPlane(List<int> directions)
        {
            return false;
        }

        public bool areNFarAway(int direction1, int direction2, int howFar)
        {
            return false;
        }

        public static List<int> retrieveAllNeighborDirections(int direction)
        {
            return null;
        }

        public static List<int> retrieveAllPerpendicularDirections(int direction)
        {
            return null;
        }

        public int[] retrieveNeighborDirections(int direction)
        {
            int[] array = new int[2];
            return array;
        }

        public int[] retrievePerpendicularDirections(int direction)
        {
            int[] array = new int[2];
            return array;
        }

        public bool areDirectionsNeighbors(int direction1, int direction2)
        {
            return false;
        }

        public bool areDirectionsPerpendicular(int direction1, int direction2)
        {
            return false;
        }

        protected void fillDirections()
        {

        }

        public Plane reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public Plane rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public Plane reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public Plane rotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public List<int> planeDirections
        {
            get
            {
                return null;
            }
        }

        public Point PlaneCentre { get; set; }

        public int PlaneNumber { get; }

        public int PlaneDimension { get { return 1; } }
    }
}
