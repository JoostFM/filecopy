using Microsoft.Extensions.Options;
using System.IO.Abstractions;

namespace FileCopy.Wif.Targets;

public interface IArtworkTargetService : ITarget
{
}

public class ArtworkTargetService(IFileSystem fileSystem,
    IOptions<ArtworkSettingsOptions> options) : IArtworkTargetService
{
    private readonly ArtworkSettingsOptions _options = options.Value;

    public async Task UpdateAsync(string filename)
    {
        string sourcePath = Path.Combine(_options.SourceLocation, filename + ".jpg");
        using var sourceStream = fileSystem.File.OpenRead(sourcePath);

        if (fileSystem.File.Exists(sourcePath))
        {
            using var destinationStream = fileSystem.File.Open(_options.TargetLocationFile, FileMode.Create);
            await sourceStream.CopyToAsync(destinationStream);
        }
        else
        {
            using var destinationStream = fileSystem.File.Create(_options.TargetLocationFile);
            await sourceStream.CopyToAsync(destinationStream);
        }
    }
}
