namespace TestsAreFun.Refactoring.BeforeRefactoring;

public interface IProduct
{
    decimal Price { get; set; }
    Guid Id { get; set; }
    void MarkAsUpdated(DateTime dateTime);
}