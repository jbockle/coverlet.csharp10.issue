using Xunit;

namespace TopLevelStatements.Tests;

public class MyClassTests
{
    [Theory]
    [InlineData("Bob")]
    [InlineData("Alice")]
    public void Greets(string name)
    {
        var expected = $"Hello {name}!";

        var actual = new MyClass().Greet(name);

        Assert.Equal(expected, actual);
    }
}
