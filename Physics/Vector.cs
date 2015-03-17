using System;

namespace Physics
{
    public class Vector
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }        
        }
        
        public double Y
        {
            get { return _y; }
        }

        public double Magnitude
        {
            get { return Math.Sqrt(X*X + Y*Y); }
        }

        public Vector UnitVector
        {
            get { return new Vector(_x / Magnitude, _y / Magnitude); }
        }

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Vector() : this(0.0, 0.0)
        {
        }

        public void UpdateByAddWith(Vector other)
        {
            _x += other.X;
            _y += other.Y;
        }

        public void UpdateBySubWith(Vector other)
        {
            _x -= other.X;
            _y -= other.Y;
        }

        public double Dot(Vector other)
        {
            return _x*other.X + _y*other.Y;
        }

        public static Vector operator +(Vector left, Vector right)
        {
            return new Vector(left.X + right.X, left.Y + right.Y);
        }

        public static Vector operator -(Vector left, Vector right)
        {
            return new Vector(left.X - right.X, left.Y - right.Y);
        }

        public static Vector operator *(Vector vector, double scalar)
        {
            return new Vector(vector.X * scalar, vector.Y * scalar);
        }

        public static Vector operator *(double scalar, Vector vector)
        {
            return new Vector(vector.X * scalar, vector.Y * scalar);
        }

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
}
