namespace FileCopy.Wif.Top100Data;

public interface IGoogleSheetsService
{
    string ToList();
    T ToList<T>();
}
