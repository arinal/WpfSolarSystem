using System;
using System.Windows.Media;
using System.Windows.Threading;

namespace SolarSystem
{
    public partial class MainWindow
    {
        private readonly DispatcherTimer _timer;
        private readonly CanvasManager _canvasManager;

        public MainWindow()
        {
            InitializeComponent();

            _canvasManager = new CanvasManager(_canvas);

            //_canvasManager.AddBall(Colors.Orange, mass: 1000.0, radius: 60.0, x: 500.0, y: 400.0, vx: 0.0, vy: 0.0);
            //_canvasManager.AddBall(Colors.Blue, mass: 10.0, radius: 20.0, x: 0.0, y: 200.0, vx: 1.0, vy: 0.0);

            _canvasManager.AddBall(Colors.Orange, mass: 1000.0, radius: 60.0, x: 500.0, y: 400.0, vx: 0.0, vy: 0.0);
            _canvasManager.AddBall(Colors.Pink, mass: 10.0, radius: 20.0, x: 500.0, y: 500.0, vx: 6.0, vy: 0.0);
            _canvasManager.AddBall(Colors.LightBlue, mass: 5.0, radius: 20.0, x: 500.0, y: 100.0, vx: -3.0, vy: 0.0);

            _canvasManager.AddBall(Colors.Gray, mass: 1.0, radius: 5.0, x: 500.0, y: 69, vx: 5.5, vy: 0.0);
            _canvasManager.AddBall(Colors.Blue, mass: 100.0, radius: 30.0, x: 500.0, y: 10.0, vx: 3.0, vy: 0.0);

            _canvasManager.AddBall(Colors.Yellow, mass: 1.0, radius: 6.0, x: -500.0, y: 10.0, vx: 2.5, vy: 0.0);

            _timer = new DispatcherTimer();
            _timer.Tick += TimerTick;
            _timer.Interval = new TimeSpan(160000);
            _timer.Start();
        }

        void TimerTick(object sender, EventArgs e)
        {
            _canvasManager.Render();
        }
    }
}
