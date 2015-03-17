using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Physics;

namespace SolarSystem
{
    public class Ball
    {
        private readonly BallMass _ballMass;
        private readonly Ellipse _ellipse;

        public BallMass BallMass
        {
            get { return _ballMass; }
        }

        public Ellipse Ellipse
        {
            get { return _ellipse; }
        }

        public Ball(BallMass ballMass, Color color)
        {
            _ellipse = new Ellipse();
            _ellipse.Height = _ellipse.Width = ballMass.Radius * 2;
            _ellipse.Fill = new SolidColorBrush(color);
            _ballMass = ballMass;
            UpdateLocation();
        }

        public void UpdateLocation()
        {
            _ellipse.SetValue(Canvas.LeftProperty, _ballMass.Position.X - _ballMass.Radius);
            _ellipse.SetValue(Canvas.BottomProperty, _ballMass.Position.Y - _ballMass.Radius);
        }
    }
}