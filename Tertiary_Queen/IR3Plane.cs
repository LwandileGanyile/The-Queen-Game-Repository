using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Queen
{
    public interface IR3Plane
    {
        bool areDirectionsPerpendicular(int firstDirection,int secondDirection);
        bool areDirectionsNeighbors(int firstDirection, int secondDirection);
        bool areDirectionsNFarAway(int firstDirection, int secondDirection,int howFar);
        bool areDirectionsOnPlane(List<int> directions);
        void retrieveAllPerpendicularDirections(int direction,List<int> perpendicularDirections);
        void retrieveAllNeighborDirections(int direction, List<int> neighborDirections);
        void retrieveAllDistancedDirections(int direction,int howFar, List<int> distancedDirections);
    }
}
