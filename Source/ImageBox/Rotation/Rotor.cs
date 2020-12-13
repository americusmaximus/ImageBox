using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageBox.Rotation
{
    public class Rotor
    {
        public Rotor(Image image)
        {
            Image = image ?? throw new ArgumentNullException(nameof(image));
        }

        public virtual Image Image { get; protected set; }

        public virtual Image Rotate(float theta)
        {
            var matrix = new Matrix();

            matrix.Translate(Image.Width / -2, Image.Height / -2, MatrixOrder.Append);
            matrix.RotateAt(theta, new Point(0, 0), MatrixOrder.Append);

            using (var gp = new GraphicsPath())
            {  
                // Transform image points by rotation matrix
                gp.AddPolygon(new [] { new Point(0, 0), new Point(Image.Width, 0), new Point(0, Image.Height) });
                gp.Transform(matrix);

                var pts = gp.PathPoints;

                // Create destination bitmap sized to contain rotated source image
                var bbox = GetBoundingBox(matrix);
                var result = new Bitmap(bbox.Width, bbox.Height);

                using (var g = Graphics.FromImage(result))
                {
                    var mDest = new Matrix();
                    mDest.Translate(result.Width / 2, result.Height / 2, MatrixOrder.Append);

                    g.Transform = mDest;
                    g.DrawImage(Image, pts);
                }

                return result;
            }
        }

        protected virtual Rectangle GetBoundingBox(Matrix matrix)
        {
            var gu = new GraphicsUnit();
            var rectangle = Rectangle.Round(Image.GetBounds(ref gu));

            // Transform the four points of the image, to get the resized bounding box
            var topLeft = new Point(rectangle.Left, rectangle.Top);
            var topRight = new Point(rectangle.Right, rectangle.Top);
            var bottomRight = new Point(rectangle.Right, rectangle.Bottom);
            var bottomLeft = new Point(rectangle.Left, rectangle.Bottom);
            var points = new Point[] { topLeft, topRight, bottomRight, bottomLeft };

            using (var gp = new GraphicsPath(points, new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line }))
            {
                gp.Transform(matrix);

                return Rectangle.Round(gp.GetBounds());
            }
        }
    }
}
