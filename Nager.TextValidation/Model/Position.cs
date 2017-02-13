using System;

namespace Nager.TextValidation.Model
{
    public struct Position
    {
        private double _x;
        private double _y;

        public Position(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public double Distance(Position position)
        {
            return Math.Sqrt(Math.Pow(this._x - position._x, 2) + Math.Pow(this._y - position._y, 2));
        }
    }
}
