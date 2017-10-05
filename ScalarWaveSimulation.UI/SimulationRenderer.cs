using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ScalarWaveSimulation.UI
{
    class SimulationRenderer
    {
        private Simulation _simulation = null;
        public RenderMode RenderMode { get; set; }
        public Color MainColor { get; set; }
        public Color SecondaryColor { get; set; }

        public Simulation Simulation
        {
            get
            {
                return _simulation;
            }
        }

        public SimulationRenderer(Simulation simulation, RenderMode renderMode, Color mainColor, Color secondaryColor)
        {
            _simulation = simulation;
            RenderMode = renderMode;
            MainColor = mainColor;
            SecondaryColor = secondaryColor;
        }
        public void Draw(Graphics graphics)
        {
            //Create a snapshot of displacements
            var displacementsSnapshot = _simulation.CreateDisplacementsSnapshot();

            //Displacement rendering mode only
            double maxDisplacement = 0;

            if (RenderMode == RenderMode.DisplacementColor)
            {
                maxDisplacement = displacementsSnapshot.Max(x => Math.Abs(x));
                if (maxDisplacement == 0)
                    maxDisplacement = double.Epsilon;
            }

            //Acceleration rendering mode only
            //Create a snapshot of accelerations, then smoothen it out by looking at the average of x neighbours
            //Where x is the locality size (number of nodes overall divided by 20)
            double[] smoothAccelerationSnapshot = null;
            double maxAcceleration = 0;

            if (RenderMode == RenderMode.AccelerationColor)
            {
                var localitySize = displacementsSnapshot.Count()/20;
                var accelerationsSnapshot = _simulation.CreateAccelerationsSnapshot();

                smoothAccelerationSnapshot = new double[accelerationsSnapshot.Length];

                for (var i = 0; i < smoothAccelerationSnapshot.Length; i++)
                {
                    smoothAccelerationSnapshot[i] =
                        accelerationsSnapshot.Skip(i - localitySize).Take(2*localitySize + 1).Average();
                }

                //Calculate maximal acceleration (from smooth acceleration snapshots)
                maxAcceleration = smoothAccelerationSnapshot.Max(x => Math.Abs(x));
                if (maxAcceleration == 0)
                    maxAcceleration = double.Epsilon;
            }

            //Velocity rendering mode only
            //Create a snapshots of velocities, then smoothen it out by looking at the average of x neighbours
            //Where x is the locality size (number of nodes overall divided by 10)
            double[] smoothVelocitySnapshot = null;
            double maxVelocity = 0;

            if (RenderMode == RenderMode.VelocityColor)
            {
                var localitySize = displacementsSnapshot.Count() / 10;
                var velocitySnapshot = _simulation.CreateVelocitiesSnapshot();

                smoothVelocitySnapshot = new double[velocitySnapshot.Length];

                for (var i = 0; i < smoothVelocitySnapshot.Length; i++)
                {
                    smoothVelocitySnapshot[i] =
                        velocitySnapshot.Skip(i - localitySize).Take(2 * localitySize + 1).Average();
                }

                //Calculate maximal velocity (from smooth velocity snapshots)
                maxVelocity = smoothVelocitySnapshot.Max(x => Math.Abs(x));
                if (maxVelocity == 0)
                    maxVelocity = double.Epsilon;
            }

            //Calculate thickness (thickness is basically 1 for each 100 pixels of length)
            var thickness = graphics.ClipBounds.Width / 100;

            //Create drawing points
            var drawingPoints = new List<Point>();

            for (var i = 0; i < displacementsSnapshot.Length; i++)
            {
                var x = (int)(i * (graphics.ClipBounds.Width / displacementsSnapshot.Length));
                var y =
                    (int)
                        ((int)(-displacementsSnapshot[i] + displacementsSnapshot.Length / 2) *
                         (graphics.ClipBounds.Height / displacementsSnapshot.Length));

                drawingPoints.Add(new Point(x, y));
            }

            //Actual drawing

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.Bilinear;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            graphics.Clear(Color.Black);

            for (var i = 0; i < drawingPoints.Count; i += 2)
            {
                //Calculate the rgb values based on the weight (how much the local acceleration is relative to the maximal acceleration)
                double weight = 0;

                switch (RenderMode)
                {
                    case RenderMode.SingleColor:
                        weight = 0;
                        break;
                    case RenderMode.DisplacementColor:
                        weight = Math.Abs((displacementsSnapshot[i] / maxDisplacement));
                        break;
                    case RenderMode.VelocityColor:
                        weight = Math.Abs((smoothVelocitySnapshot[i] / maxVelocity));
                        break;
                    case RenderMode.AccelerationColor:
                        weight = Math.Abs((smoothAccelerationSnapshot[i] / maxAcceleration));
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var r = (int) ((1 - weight) * MainColor.R + weight * SecondaryColor.R);
                var g = (int) ((1 - weight) * MainColor.G + weight * SecondaryColor.G);
                var b = (int) ((1 - weight) * MainColor.B + weight * SecondaryColor.B);

                var pen = new Pen(Color.FromArgb(r, g, b), thickness);

                //Draw curve using this point, the previous one and the next one
                graphics.DrawCurve(pen, drawingPoints.Skip(i - 1).Take(3).ToArray());
            }
            
            graphics.Flush(FlushIntention.Sync);
        }
    }

    internal enum RenderMode
    {
        SingleColor,
        DisplacementColor,
        VelocityColor,
        AccelerationColor
    }
}
