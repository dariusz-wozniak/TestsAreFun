using TestsAreFun.Animals;

namespace TestsAreFun.Tests.Unit._01_NUnitBasics;

public class TypeTests
{
    [Test]
    public void type_test_classic_model()
    {
        var dog = new Dog();

        // Is of exact type:
        Assert.AreEqual(typeof(Dog), dog.GetType());

        // Is instance of:
        Assert.IsInstanceOf<Dog>(dog);
        Assert.IsInstanceOf<Animal>(dog);
        Assert.IsNotInstanceOf<JackRussellTerrier>(dog);

        // Is assignable from:
        Assert.IsNotAssignableFrom<Animal>(dog);
        Assert.IsAssignableFrom<Dog>(dog);
        Assert.IsAssignableFrom<JackRussellTerrier>(dog);
    }

    [Test]
    public void type_test_constraint_model()
    {
        var dog = new Dog();

        // Is of exact type:
        Assert.That(dog, Is.TypeOf<Dog>());

        // Is instance of:
        Assert.That(dog, Is.InstanceOf<Animal>());
        Assert.That(dog, Is.InstanceOf<Dog>());
        Assert.That(dog, Is.Not.InstanceOf<JackRussellTerrier>());

        // Is assignable from:
        Assert.That(dog, Is.Not.AssignableFrom<Animal>());
        Assert.That(dog, Is.AssignableFrom<Dog>());
        Assert.That(dog, Is.AssignableFrom<JackRussellTerrier>());

        // Is assignable to:
        Assert.That(dog, Is.AssignableTo<Animal>());
        Assert.That(dog, Is.AssignableTo<Dog>());
        Assert.That(dog, Is.Not.AssignableTo<JackRussellTerrier>());
    }
}