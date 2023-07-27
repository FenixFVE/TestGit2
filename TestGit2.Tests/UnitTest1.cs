
using TestGit2;

namespace TestGit2.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That(Program.AddFunction(2, 2), Is.EqualTo(4));
    }
}