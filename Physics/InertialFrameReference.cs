using System.Collections.Generic;

namespace Physics
{
    public class InertialFrameReference
    {
        private const double GravityConst = 3;
        private readonly List<BallMass> _ballMasses;

        public IEnumerable<BallMass> BallMasses
        {
            get { return _ballMasses; }
        }

        public InertialFrameReference()
        {
            _ballMasses = new List<BallMass>();
        }

        public void AddBallMass(BallMass ball)
        {
            _ballMasses.Add(ball);
        }

        public void RemoveBallMass(BallMass ball)
        {
            _ballMasses.Remove(ball);
        }

        public void DoPhysics()
        {
            foreach (var mass in BallMasses)
                UpdateAcceleration(mass);
            foreach (var mass in BallMasses)
                UpdatePosition(mass);
        }        

        void UpdateAcceleration(BallMass ball)
        {
            var resultant = new Vector();
            foreach (var b in BallMasses)
            {
                if ( b == ball )
                    continue;
                var distance = b.Position - ball.Position;
                var distanceValue = distance.Magnitude;
                var accel = GravityConst * b.Mass / (distanceValue * distanceValue);
                resultant.UpdateByAddWith(accel * distance.UnitVector);
            }
            ball.Acceleration = resultant;
        }

        void UpdatePosition(BallMass ball)
        {
            ball.Velocity.UpdateByAddWith(ball.Acceleration);
            ball.Position.UpdateByAddWith(ball.Velocity);
        }
    }
}