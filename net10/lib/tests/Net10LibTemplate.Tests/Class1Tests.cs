namespace Net10LibTemplate.Tests;

public class Class1Tests
{
    [Fact]
    public void Test_Method1()
    {
        var class1 = new Class1();

        var result = class1.Method1();

        Assert.Equal("Hello!", result);
    }
}
