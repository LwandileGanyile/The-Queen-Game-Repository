using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;

namespace Secondary_Queen
{
    public class R2CircularDirection : CircularDirection<R2CircularDirection,R2Point>
    {
      
        public R2CircularDirection():base()
        {
            dimension = 2;
            fillDirection();
        }

        public R2CircularDirection(R2Point startingPoint, int direction, float directionLength, float directionDivisor, List<bool> canShootList, int directionDuration)
        : this(startingPoint, direction, directionLength, directionDivisor, canShootList, directionDuration, 1)
        {
            
        }

        public R2CircularDirection(R2Point startingPoint, int direction, float directionLength, float divisor, List<bool> canShootList, int directionDuration, int numberOfRotations)
        : base(startingPoint.Point, direction,divisor,canShootList,directionDuration,numberOfRotations)
        {
            this.directionLength = directionLength;
            dimension = 2;
            fillDirection();
        }

       

        public override void fillDirection()
        {
            R2Point point = new R2Point(StartingPoint);
            CircularLinkedList<R2Point> circularLinkedList = new CircularLinkedList<R2Point>();



            switch (direction)
            {
                case 1:
                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate() - i * divisor, point.getYCoordinate()));
                    break;
                case 2:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate(), point.getYCoordinate() + i * divisor));

                    break;
                case 3:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate(), point.getYCoordinate() - i * divisor));

                    break;
                case 4:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate() - i * divisor, point.getYCoordinate() + i * divisor));

                    break;
                case 5:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate() + i * divisor, point.getYCoordinate() - i * divisor));

                    break;
                case 6:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate() + i * divisor, point.getYCoordinate() + i * divisor));
                    
                    break;
                case 7:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate() - i * divisor, point.getYCoordinate() - i * divisor));

                    break;
                case 8:

                    for (int i = 0; i < directionLength / divisor; i++)
                        circularLinkedList.add(new R2Point(point.getXCoordinate()+i*divisor,point.getYCoordinate()));
                    
                    break;
                    
            }
        }

        public override void display()
        {
            for (int i = 0; i < circularLinkedList.Size; i++)
            
                circularLinkedList.getAt(i).display();
        }

        public override int getDimension()
        {
            return 2; 
        }

        public override int getDirection()
        {
            return direction;
        }

        public override float getDirectionDivisor()
        {
            return divisor;
        }

        public override float getDirectionLength()
        {
            return directionLength; ;
        }

        public override int getDuration()
        {
            return duration;
        }

        public override Point getStartingPoint()
        {
            return _startingPoint;
        }

       
        public override bool isDirectionDimensionCorrect()
        {
            return 2==getDimension();
        }

        public override bool isDirectionValid(int direction)
        {
            return direction >= 1 && direction <= 8;
        }

        public override bool isPointDimensionCorrect()
        {
            return StartingPoint.getDimension() == 2;
        }

        public override R2CircularDirection reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override R2CircularDirection reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2CircularDirection rotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2CircularDirection rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override void setCanShootList(List<bool> canShootList)
        {
            this.canShootList = canShootList;
        }

        public override void setDirectionDivisor(float directionDivisor)
        {
            this.divisor = directionDivisor;
        }

        public override void setDirectionLength(float directionLength)
        {
            this.directionLength = directionLength;
        }

        public override void setDuration(int timeInMiliiseconds)
        {
            this.duration = timeInMiliiseconds;
        }

        public override void setStartingPoint(Point startingPoint)
        {
            StartingPoint = startingPoint;
        }

        public override R2CircularDirection translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }

}
