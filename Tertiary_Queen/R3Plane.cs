using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;

namespace Tertiary_Queen
{
    public class R3Plane:IR3Plane
    {
        private IR3Plane planePerspective;

        public R3Plane()
        {

        }

        public R3Plane(IR3Plane planePerspective)
        {

        }

        public bool areDirectionsNeighbors(int firstDirection, int secondDirection)
        {
            return planePerspective.areDirectionsNeighbors(firstDirection, secondDirection);
        }

        public bool areDirectionsNFarAway(int firstDirection, int secondDirection, int howFar)
        {
            return planePerspective.areDirectionsNFarAway(firstDirection, secondDirection, howFar);
        }

        public bool areDirectionsOnPlane(List<int> directions)
        {
            return planePerspective.areDirectionsOnPlane(directions);
        }

        public bool areDirectionsPerpendicular(int firstDirection, int secondDirection)
        {
            return planePerspective.areDirectionsPerpendicular(firstDirection, secondDirection);
        }

        public void changePlanePerspective(IR3Plane planePerspectiv)
        {
            this.planePerspective = planePerspectiv;
        }

        public void retrieveAllDistancedDirections(int direction, int howFar, List<int> distancedDirections)
        {
            planePerspective.retrieveAllDistancedDirections(direction, howFar, distancedDirections);
        }

        public void retrieveAllNeighborDirections(int direction, List<int> neighborDirections)
        {
            planePerspective.retrieveAllNeighborDirections(direction, neighborDirections);
        }

        public void retrieveAllPerpendicularDirections(int direction, List<int> perpendicularDirections)
        {
            planePerspective.retrieveAllPerpendicularDirections(direction, perpendicularDirections);
        }

        public void setPlaneCentre(R3Point point)
        {

        }

    }
}
