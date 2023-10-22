using Microsoft.AspNetCore.Mvc.Testing;

namespace AwesomeApi.Tests;

public class UnitTest1 
{
    static UnitTest1()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        using var httpResponse = client.GetAsync("ok").Result;
    } 

    [Fact]
    public void Test()
    { }
} 

public class UnitTest2
{
    static UnitTest2()
    {
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient();
        using var httpResponse = client.GetAsync("ok").Result;
    }
    
    [Fact]
    public void Test()
    { }
}