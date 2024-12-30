using Microsoft.Extensions.Options;
using System.IO.Abstractions;

namespace FileCopy.Wif.Targets;

public interface INowPlayingTargetService : ITarget
{
}

public class NowPlayingTargetService(IFileSystem fileSystem,
    IOptions<ArtworkSettingsOptions> options) : INowPlayingTargetService
{
    private readonly ArtworkSettingsOptions _options = options.Value;

    public async Task UpdateAsync(string value)
    {
        fileSystem.File.WriteAllText(_options.TargetNowPlayingFile, value);
        await Task.CompletedTask;
    }
}
