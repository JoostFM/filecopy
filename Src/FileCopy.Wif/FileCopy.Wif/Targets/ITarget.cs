namespace FileCopy.Wif.Targets;

public interface ITarget
{
    Task UpdateAsync(string value);
}
