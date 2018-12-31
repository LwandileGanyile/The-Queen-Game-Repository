using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace Pieces
{
    public class Point : RetrievableDimension, IDisplay
    {
        private List<float> _coordinates;


        public Point()
        {

        }

        public Point(List<float> coordinates, bool canShoot)
        {

        }

        public bool canShoot { get; set; }

        public void setAxisAt(int coordinateAt, float value)
        {

        }

        public float getAxisAt(int coordinateAt)
        {
            return 1.0f;
        }

        public List<float> getPoint()
        {
            return null;
        }

        public void decreaseAxisAt(int coordinateAt, float amount)
        {

        }

        public void increaseAxisAt(int coordinateAt, float amount)
        {

        }

        public int getDimension()
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            throw new NotImplementedException();
        }
    }
}
