namespace TopLevelStatements;

public class MyClass
{
    public string Template { get; init; } = "Hello {0}!";

    public string Greet(string name)
    {
        return string.Format(Template, name);
    }
}
