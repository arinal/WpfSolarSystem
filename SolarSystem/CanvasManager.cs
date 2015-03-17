using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using Physics;

namespace SolarSystem
{
    public class CanvasManager
    {
        private readonly InertialFrameReference _engine;
        private readonly Canvas _canvas;
        private readonly List<Ball> _balls;

        public CanvasManager(Canvas canvas)
        {
            _canvas = canvas;
            _balls = new List<Ball>();
            _engine = new InertialFrameReference();
        }
        
        public void Render()
        {
            _engine.DoPhysics();
            foreach (var b in _balls)
                b.UpdateLocation();
        }

        public void AddBall(Color color, double mass = 1.0, double radius = 5.0,
            double x = 0.0, double y = 0.0, double vx = 0.0, double vy = 0.0)
        {
            var ball = new Ball(new BallMass
                                    {
                                        Mass = mass,
                                        Radius = radius,
                                        Position = new Vector(x, y),
                                        Velocity = new Vector(vx, vy),
                                    }, color);
            _balls.Add(ball);
            _engine.AddBallMass(ball.BallMass);
            _canvas.Children.Add(ball.Ellipse);
        }
    }
}
