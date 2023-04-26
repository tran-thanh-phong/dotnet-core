namespace SOLIDPriciples.OpenClosedPrinciple.Correct
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrRectangles)
        {
            double area = 0;

            foreach (var obj in arrRectangles)
            {
                area += obj.Area();
            }

            return area;
        }
    }
}
