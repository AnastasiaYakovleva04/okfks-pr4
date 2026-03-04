using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            try
            {
                if (CorrectValues())
                    return Width * Height;
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
                    return 2 * (Width + Height);
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
            return $"Ширина = {Width} Высота = {Height}";
        }
        private bool CorrectValues()
        {
            if (Width <= 0 || Height <= 0)
                return false;
            return true;
        }
    }
}
