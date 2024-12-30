using static System.Net.Mime.MediaTypeNames;

namespace FileCopy.Wif.Models;

public class TrackData
{
    public int Position { get; set; }
    public string Artist { get; set; }
    public string Title { get; set; }
    public string Description => Position.ToString().PadLeft(3) + ". " + MaxText(Artist,30) + " - " + MaxText(Title,30);

    private string MaxText(string text, int length) 
    {
        if (text.Length > 30) 
        { return  text[..length]; } else { return text.PadRight(length);
        } 
    }
}
