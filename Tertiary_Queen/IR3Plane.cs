using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Queen
{
    public interface IR3Plane
    {
        bool AreDirectionsPerpendicular(int firstDirection,int secondDirection);
        bool AreDirectionsNeighbors(int firstDirection, int secondDirection);
        bool AreDirectionsNFarAway(int firstDirection, int secondDirection,int howFar);
        bool AreDirectionsOnPlane(List<int> directions);
        void RetrieveAllPerpendicularDirections(int direction,List<int> perpendicularDirections);
        void RetrieveAllNeighborDirections(int direction, List<int> neighborDirections);
        void RetrieveAllDistancedDirections(int direction,int howFar, List<int> distancedDirections);
    }
}
