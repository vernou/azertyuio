using Microsoft.AspNetCore.Mvc.Testing;

namespace AwesomeApi.Tests;

public class UnitTest1
{
    static UnitTest1()
    {
        Task.Run(async () =>
        {
            using var factory = new WebApplicationFactory<Program>();
            using var client = factory.CreateClient();
            using var httpResponse = await client.GetAsync("ok");
        });
    }

    [Fact]
    public void Test()
    { }
}

public class UnitTest2
{
    static UnitTest2()
    {
        Task.Run(async () =>
        {
            using var factory = new WebApplicationFactory<Program>();
            using var client = factory.CreateClient();
            using var httpResponse = await client.GetAsync("ok");
        });
    }

    [Fact]
    public void Test()
    { }
}