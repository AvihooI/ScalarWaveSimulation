using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ScalarWaveSimulation.Comparison
{
    class ComparisonRenderer
    {

        public void Draw(Graphics graphics, double[] numericalSnapshot, double[] analyticalSnapshot)
        {
            //Create drawing points
            var numericalDrawingPoints = new List<Point>();

            for (var i = 0; i < numericalSnapshot.Length; i++)
            {
                var x = (int)(i * (graphics.ClipBounds.Width / numericalSnapshot.Length));
                var y =
                    (int)
                        ((int)(-numericalSnapshot[i] + numericalSnapshot.Length / 2) *
                         (graphics.ClipBounds.Height / numericalSnapshot.Length));

                numericalDrawingPoints.Add(new Point(x, y));
            }

            var analyticalDrawingPoints = new List<Point>();

            for (var i = 0; i < analyticalSnapshot.Length; i++)
            {
                var x = (int)(i * (graphics.ClipBounds.Width / analyticalSnapshot.Length));
                var y =
                    (int)
                        ((int)(-analyticalSnapshot[i] + analyticalSnapshot.Length / 2) *
                         (graphics.ClipBounds.Height / analyticalSnapshot.Length));

                analyticalDrawingPoints.Add(new Point(x, y));
            }

            //Actual drawing

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.Bilinear;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            graphics.Clear(Color.Black);

            for (var i = 0; i < analyticalDrawingPoints.Count; i += 2)
            {
                var pen = new Pen(Color.Red, 3);

                //Draw curve using this point, the previous one and the next one
                graphics.DrawCurve(pen, analyticalDrawingPoints.Skip(i - 1).Take(3).ToArray());
            }

            for (var i = 1; i < numericalDrawingPoints.Count-1; i += 2)
            {
                var pen = new Pen(Color.Blue, 3);

                //Draw curve using this point, the previous one and the next one
                graphics.DrawCurve(pen, numericalDrawingPoints.Skip(i - 1).Take(3).ToArray());
            }
            
            graphics.Flush(FlushIntention.Sync);
        }

    }

}
