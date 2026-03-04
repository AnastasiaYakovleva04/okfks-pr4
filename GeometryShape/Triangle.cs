using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle: Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public override double Area()
        {
            try
            {
                if (CorrectValues())
                {
                    if (TriangleExist())
                    {
                        double p = Perimeter() / 2;
                        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                    }
                    else
                        throw new ArgumentException("Такого треугольник не существует. Неправильно введены стороны");
                }
                else
                    throw new ArgumentException("Стороны не могут быть меньше либо равны нулю");
            }
            catch
            {
                throw new ArgumentException("Некорректные данные");
            }
        }
        public override double Perimeter()
        {
            try
            {
                if (CorrectValues())
                {
                    if (TriangleExist())
                        return SideA + SideB + SideC;
                    else
                        throw new ArgumentException("Такого треугольник не существует. Неправильно введены стороны");
                }
                else
                    throw new ArgumentException("Стороны не могут быть меньше либо равны нулю");
            }
            catch
            {
                throw new ArgumentException("Некорректные данные");
            }
        }
        public override string ToString()
        {
            return $"Сторона А = {SideA} Сторона В = {SideB} Сторона С = {SideC}";
        }
        private bool TriangleExist()
        {
            if ((SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA))
                return true;
            return false;
        }
        private bool CorrectValues()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <=0)
                return false;
            return true;
        }
    }
}
