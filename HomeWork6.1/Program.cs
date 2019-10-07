using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6._1
{
    abstract class Figure
    {
        public string[] ColorArray = { "Зеленый", "Синий", "Черный", "Белый", "Серый", "Коричневый", "Желтый", "Розовый", "Фиолетовый", "Красный", };
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();
        public abstract string Color();
        public void ShowInfo()
        {
            Console.WriteLine("Название фигуры: " + ShapeName() + "\n" + "Площадь: " + Area() + "\n" + "Периметр: " + Perimeter() + "\n" + "Цвет фигуры: " + Color());
            Console.WriteLine();
        }
    }

    class Triangle : Figure
    {
        double sideA, sideB, sideC;   // Стороны треугольника

        // Конструктор
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            sideA = triangleSideA;
            sideB = triangleSideB;
            sideC = triangleSideC;
        }

        // Метод для вычисления площади треугольника
        public override string Area()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }

        // Метод для вычисления периметра треугольника
        public override string Perimeter()
        {
            return (sideA + sideB + sideC).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Треугольник";
        }
        //метод для рандомного цвета
        public override string Color() // пробовал добавить просчет рандома в один метод и потом 
            //добавлять его к фигурам чтоб сьекономить строки, но заебался придумывать.
        {
            Random rnd = new Random();
            int i = rnd.Next(0, ColorArray.Length);
            return ColorArray[i];
        }
    }

    class Circle : Figure
    {
        double side;   // Сторона квадрата

        // Конструктор
        public Circle(double circleSide)
        {
            side = circleSide;
        }

        // Метод для вычисления площади круга
        public override string Area()
        {
            return (side * side * Math.PI).ToString();
        }

        // Метод для вычисления периметра круга
        public override string Perimeter()
        {
            return ((side * side) * Math.PI).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Круг";
        }
        //метод для рандомного цвета
        public override string Color()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, ColorArray.Length);
            return ColorArray[i];
        }
    }

    class Rectangle : Figure
    {
        double width;   // Ширина прямоугольника
        double height;   // Высота прямоугольника

        // Конструктор
        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            width = rectangleWidth;
            height = rectangleHeight;
        }


        // Метод для вычисления площади прямоугольника
        public override string Area()
        {
            return (width * height).ToString();
        }

        // Метод для вычисления периметра прямоугольника
        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString();
        }

        // Метод возвращающий наименование фигуры
        public override string ShapeName()
        {
            return "Прямоугольник";
        }
        //метод для рандомного цвета
        public override string Color()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, ColorArray.Length);
            return ColorArray[i];
        }
    }

    class Program
    {
        static void Main()
        {
            // Если надо сделать просчет по выбору, легко добавляется свитч.

            Console.WriteLine("Введите длинну трех сторон треугольника:");
            Figure figure1 = new Triangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            figure1.ShowInfo();

            Console.WriteLine("ВВедите длинну радиуса круга:");
            Figure figure2 = new Circle(Convert.ToDouble(Console.ReadLine()));
            figure2.ShowInfo();

            Console.WriteLine("Введите высоту и длинну прямоугольника:");
            Figure figure3 = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            figure3.ShowInfo();

            Console.ReadKey();
        }
    }
}
