using System;

namespace Nager.TextValidation.Model
{
    public struct Position
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Position(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Distance(Position position)
        {
            var multiplier = 5; //Increase the distance of rows;
            var y1 = this.Y * multiplier;
            var y2 = position.Y * multiplier;

            var distance = Math.Sqrt(Math.Pow(this.X - position.X, 2) + Math.Pow(y1 - y2, 2));
            return distance;
        }
    }
}
