namespace SOLIDPriciples.OpenClosedPrinciple
{
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class AreaCalculator
    {
        public double TotalArea(object[] arrRectangles)
        {
            double area = 0;

            Rectangle objRectangle;
            Circle objCircle;

            foreach (var obj in arrRectangles)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
