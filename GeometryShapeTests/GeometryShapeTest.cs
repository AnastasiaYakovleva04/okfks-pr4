using GeometryShape;
using System.Net.Sockets;

namespace GeometryShapeTests
{
    public class GeometryShapeTest
    {
        [Fact]
        public void RectangleArea_HnegW50_ReturnArgumentException()
        {
            Rectangle rect = new() { Height = -10, Width = 50 };
            Assert.Throws<ArgumentException>(() => rect.Area());
        }
        [Fact]
        public void RectangleArea_Hn50Wneg_ReturnArgumentException()
        {
            Rectangle rect = new() { Height = 50, Width = -10 };
            Assert.Throws<ArgumentException>(() => rect.Area());
        }
        [Fact]
        public void RectangleArea_H10W5point5_Return55()
        {
            Rectangle rect = new() { Height = 10, Width = 5.5 };
            const double RectangleAreaH10W5point5 = 55;
            var actual = rect.Area();
            Assert.Equal(RectangleAreaH10W5point5, actual);
        }
        [Fact]
        public void RectanglePerimeter_H0W5_ReturnArgumentException()
        {
            Rectangle rect = new() { Height = 0, Width = 5 };
            Assert.Throws<ArgumentException>(() => rect.Perimeter());
        }
        [Fact]
        public void RectanglePerimeter_H5W0_ReturnArgumentException()
        {
            Rectangle rect = new() { Height = 5, Width = 0 };
            Assert.Throws<ArgumentException>(() => rect.Perimeter());
        }
        [Fact]
        public void RectanglePerimeter_H5W10_Return30()
        {
            Rectangle rect = new() { Height = 5, Width = 10 };
            const double RectanglePerimeterH5W10 = 30;
            var actual = rect.Perimeter();
            Assert.Equal(RectanglePerimeterH5W10, actual);
        }

    }
}