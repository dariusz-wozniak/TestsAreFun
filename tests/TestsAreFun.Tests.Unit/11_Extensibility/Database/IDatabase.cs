namespace TestsAreFun.Tests.Unit._11_Extensibility.Database;

public interface IDatabase
{
    void OpenConnection();

    void CloseConnection();

    T Query<T>(string query);

    string Username { get; set; }

    bool IsPoolingEnabled { get; set; }
}