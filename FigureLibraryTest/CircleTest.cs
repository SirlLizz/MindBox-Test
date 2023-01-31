using FigureLibrary.Figures;
using NUnit.Framework;

namespace FigureLibraryTest
{
    public class CircleTest
    {
        [Test]
        public void CircleSquare()
        {
            Circle circle = new Circle(10);
            Assert.That(circle.GetSquare(), Is.EqualTo(628.31853071795865));
        }
    }
}