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

        public bool AreDirectionsNeighbors(int firstDirection, int secondDirection)
        {
            return planePerspective.AreDirectionsNeighbors(firstDirection, secondDirection);
        }

        public bool AreDirectionsNFarAway(int firstDirection, int secondDirection, int howFar)
        {
            return planePerspective.AreDirectionsNFarAway(firstDirection, secondDirection, howFar);
        }

        public bool AreDirectionsOnPlane(List<int> directions)
        {
            return planePerspective.AreDirectionsOnPlane(directions);
        }

        public bool AreDirectionsPerpendicular(int firstDirection, int secondDirection)
        {
            return planePerspective.AreDirectionsPerpendicular(firstDirection, secondDirection);
        }

        public void changePlanePerspective(IR3Plane planePerspectiv)
        {
            this.planePerspective = planePerspectiv;
        }

        public void RetrieveAllDistancedDirections(int direction, int howFar, List<int> distancedDirections)
        {
            planePerspective.RetrieveAllDistancedDirections(direction, howFar, distancedDirections);
        }

        public void RetrieveAllNeighborDirections(int direction, List<int> neighborDirections)
        {
            planePerspective.RetrieveAllNeighborDirections(direction, neighborDirections);
        }

        public void RetrieveAllPerpendicularDirections(int direction, List<int> perpendicularDirections)
        {
            planePerspective.RetrieveAllPerpendicularDirections(direction, perpendicularDirections);
        }

        public void SetPlaneCentre(R3Point point)
        {

        }

    }
}
