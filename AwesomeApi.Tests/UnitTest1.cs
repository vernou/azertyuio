using Microsoft.AspNetCore.Mvc.Testing;

namespace AwesomeApi.Tests;

public class UnitTest1 : IClassFixture<Fixture>
{
    [Fact]
    public void Test()
    { }
}

public class UnitTest2 : IClassFixture<Fixture>
{
    [Fact]
    public void Test()
    { }
}

public class Fixture
{
    public Fixture()
    {
        Task.Run(() =>
        {
            using var factory = new WebApplicationFactory<Program>();
            using var client = factory.CreateClient();
            using var httpResponse = client.GetAsync("ok").Result;
        });
    }
}