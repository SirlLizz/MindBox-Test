using FigureLibrary.Figures;
using NUnit.Framework;

namespace FigureLibraryTest
{
    public class TriangleTest
    {
        [Test]
        public void TriangleSquare()
        {
            Triangle triangle = new Triangle(10,10,10);
            Assert.That(triangle.GetSquare(), Is.EqualTo(43.301270189221931));
        }

        [Test]
        public void TriangleRectificationCheckTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.RectificationCheck());
        }

        [Test]
        public void TriangleRectificationCheckFalse()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.RectificationCheck());
        }
    }
}
