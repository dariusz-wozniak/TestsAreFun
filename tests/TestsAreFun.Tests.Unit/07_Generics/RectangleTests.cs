using TestsAreFun.Shapes;

namespace TestsAreFun.Tests.Unit._07_Generics;

[TestFixture(typeof(Rectangle))]
[TestFixture(typeof(Square), Explicit = true)] // This test fails Liskov Substitution Principle
public class RectangleTests<T> where T : Rectangle, new()
{
    [Test]
    public void width_and_height_should_be_invariant()
    {
        var rectangle = new T
        {
            Height = 30,
            Width = 40
        };

        Assert.That(rectangle.Height, Is.EqualTo(30));
        Assert.That(rectangle.Width, Is.EqualTo(40));
    }
}