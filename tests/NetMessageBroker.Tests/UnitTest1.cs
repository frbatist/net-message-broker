using NetMessageBroker;
using FluentAssertions;

namespace NetMessageBroker.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var teste = new Class1();

        var iiii = teste.GetCoiso();

        iiii.Should().Be(10);
    }
}