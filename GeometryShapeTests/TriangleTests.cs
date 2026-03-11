using GeometryShape;
using System.Net.Sockets;

namespace GeometryShapeTests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleArea_AnegB10C3_ReturnArgumentException()
        {
            Triangle triangle = new() { SideA = -10, SideB = 10, SideC = 3 };
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }
        [Fact]
        public void TriangleArea_A0B10C3_ReturnArgumentException()
        {
            Triangle triangle = new() { SideA = 0, SideB = 10, SideC = 3 };
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }
        [Fact]
        public void TriangleArea_A1B2C3_ReturnArgumentException()
        {
            Triangle triangle = new() { SideA = 1, SideB = 2, SideC = 3 };
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }
        [Fact]
        public void TriangleArea_A3B4C5_Return6()
        {
            Triangle triangle = new() { SideA = 3, SideB = 4, SideC = 5 };
            const double RightAngledTriangleArea = 6;
            var actual = triangle.Area();
            Assert.Equal(RightAngledTriangleArea, actual);
        }
        [Fact]
        public void TriangleArea_A5B5C8_Return12()
        {
            Triangle triangle = new() { SideA = 5, SideB = 5, SideC = 8 };
            const double IsoscelesTriangleArea = 12;
            var actual = triangle.Area();
            Assert.Equal(IsoscelesTriangleArea, actual);
        }

        [Fact]
        public void TrianglePerimeter_AnegB10C3_ReturnArgumentException()
        {
            Triangle triangle = new() { SideA = -10, SideB = 10, SideC = 3 };
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }
        [Fact]
        public void TrianglePerimeter_A0B10C3_ReturnArgumentException()
        {
            Triangle triangle = new() { SideA = 0, SideB = 10, SideC = 3 };
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }
        [Fact]
        public void TrianglePerimeter_A1B2C3_ReturnArgumentException()
        {
            Triangle triangle = new() { SideA = 1, SideB = 2, SideC = 3 };
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }
        [Fact]
        public void TrianglePerimeter_A5B5C5_Return15()
        {
            Triangle triangle = new() { SideA = 5, SideB = 5, SideC = 5 };
            const double EquilateralTrianglePerimeterSides5 = 10;
            var actual = triangle.Perimeter();
            Assert.Equal(EquilateralTrianglePerimeterSides5, actual);
        }
    }
}
