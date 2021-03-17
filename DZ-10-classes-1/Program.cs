using System;

namespace DZ_10_classes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина стороны х прямоугольника: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны у прямоугольника: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Rectangle z = new Rectangle (x,y);

            Console.WriteLine($"Площадь прямоугольника: {z.Area} ед.");
            Console.WriteLine($"Периметр прямоугольника: {z.Perimeter} ед.");


        }
    }

    public class Rectangle
    {
        //поля
        double side1, side2;
       
        //конструктор
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        //метод вычисления площади
        static double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;

        }

        //свойство площадь
        public double Area
        {

            get { return AreaCalculator(side1, side2); }
        }

        //метод вычисления периметра
        static double PerimeterCalculator(double side1, double side2)
        {
            return side1 * 2 + side2 * 2;
        }

        //свойство периметр
        public double Perimeter
        {
            get { return PerimeterCalculator(side1, side2); }
        }
    }
}
