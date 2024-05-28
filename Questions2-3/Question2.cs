namespace Questions2_3
{

    public interface Figure
    {
        public double Area();
    }





    public class Triangle : Figure
    {
        private List<double> Sides;

        public Triangle(double Side1, double Side2, double Side3)
        {
            Sides = new List<double>(3);

            Sides.Add(Side1);
            Sides.Add(Side2);
            Sides.Add(Side3);

            Sides.Sort();

            if (!IsPossible())
            {
                Console.WriteLine("Я бы тут выкинул ArgumentException, но пускай будет просто предупреждение:" +
                    " треугольник с такими сторонами невозможен");
            }
        }


        public double Area()
        {
            double area;


            if (IsRight())
            {
                area = Sides[0] * Sides[1] / 2;
                return area;
            }

            double perimeter = Sides.Sum();
            area = Math.Sqrt(perimeter * (perimeter - Sides[0]) * (perimeter - Sides[1]) * (perimeter - Sides[2]));

            return area;

        }

        private bool IsPossible()
        {
            bool st1 = Sides[0] + Sides[1] > Sides[2];
            bool st2 = Sides[1] + Sides[2] > Sides[0];
            bool st3 = Sides[2] + Sides[0] > Sides[1];

            return st1 && st2 && st3;
        }
        private bool IsRight()
        {
            bool st = Math.Pow(Sides[0],2) + Math.Pow(Sides[1],2) == Math.Pow(Sides[2],2);
            return st;
        }
    }





    public class Circle : Figure
    {
        public double Radius;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
}