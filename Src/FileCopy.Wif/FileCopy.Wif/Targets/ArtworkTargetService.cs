using Microsoft.Extensions.Options;
using System.IO.Abstractions;

namespace FileCopy.Wif.Targets;

public interface IArtworkTargetService : ITarget
{
    Task<bool> CheckAsync(string filename);
}

public class ArtworkTargetService(IFileSystem fileSystem,
    IOptions<ArtworkSettingsOptions> options) : IArtworkTargetService
{
    private readonly ArtworkSettingsOptions _options = options.Value;

    public async Task<bool> CheckAsync(string filename)
    {
        var safeFilename = string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        string sourcePath = Path.Combine(_options.SourceLocation, safeFilename + ".jpg");

        await Task.CompletedTask;

        return  fileSystem.File.Exists(sourcePath);
    }

    public async Task UpdateAsync(string filename)
    {
        var safeFilename = string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        string sourcePath = Path.Combine(_options.SourceLocation, safeFilename + ".jpg");
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
