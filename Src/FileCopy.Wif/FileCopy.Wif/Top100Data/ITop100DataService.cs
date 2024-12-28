using FileCopy.Wif.Models;

namespace FileCopy.Wif.Top100Data;

public  interface ITop100DataService
{
    List<TrackData> ToList();
}
