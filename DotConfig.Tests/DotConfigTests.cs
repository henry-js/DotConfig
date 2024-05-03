using DotConfig;
using FluentAssertions;
namespace DotConfig.Tests;

public class DotConfigTests
{
    [Fact]
    public void CanDetermineIfConfigExists()
    {
        var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        var dir = Path.Combine(userProfile, ".config");
        DotConfig.Exists.Should().Be(Directory.Exists(dir));
    }
}
