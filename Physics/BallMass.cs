namespace Physics
{
    public class BallMass
    {
        public double Radius { get; set; }
        public double Mass { get; set; }

        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
        public Vector Acceleration { get; set; }

        public BallMass()
        {
            Position = new Vector();
            Velocity = new Vector();
            Acceleration = new Vector();
        }

        public void AddToVelocity(Vector vector)
        {
            Velocity.UpdateByAddWith(vector);
        }

        public void AddToAcceleration(Vector vector)
        {
            Acceleration.UpdateByAddWith(vector);
        }
    }
}
