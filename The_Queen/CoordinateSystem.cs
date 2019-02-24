using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Queen
{
    public abstract class CoordinateSystem
    {
        protected float _delta;
        protected float _minimumBoundary;
        protected float _maximumBoundary;
        protected int indexOfCurrentQueen;
        protected int indexOfCurrentKing;
        protected List<Queen> queens;
        protected List<King> kings;

        protected CoordinateSystem()
        {

        }

        protected CoordinateSystem(float delta, float minimumBoundary, float maximumBoundary)
        {

        }

        protected CoordinateSystem(float delta, float minimumBoundary, float maximumBoundary, 
        int indexOfCurrentQueen, List<Queen> queens)
        {

        }

        protected CoordinateSystem(float delta, float minimumBoundary, float maximumBoundary,
        int indexOfCurrentKing, List<King> kings)
        {

        }

        protected CoordinateSystem(float delta, float minimumBoundary, float maximumBoundary,
        int indexOfCurrentQueen, List<Queen> queens, int indexOfCurrentKing, List<King> kings)
        {

        }


        public void AddQueen(Queen queen)
        {

        }

        public void AddKing(King king)
        {

        }

        public void RemomveQueenAt(int indexOfQueen)
        {

        }

        public void RemomveKingAt(int indexOfKing)
        {

        }

        private bool AreBoundariesValid(float minimumBoundary, float maximumBoundary)
        {
            return true;
        }

        private bool IsDeltaValid(float delta)
        {
            return true;
        }

        private bool IsValidCoordinateSystem(float minimumBoundary, float maximumBoundary, float delta)
        {
            return false;
        }

        private void SetMinMaxDelta(float minimumBoundary, float maximumBoundary, float delta)
        {

        }

        public void Update()
        {

        }

        public void Stop()
        {

        }

        public void Resume()
        {

        }

    }
}
