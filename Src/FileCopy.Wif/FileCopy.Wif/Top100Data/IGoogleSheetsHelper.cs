using Google.Apis.Sheets.v4;

namespace FileCopy.Wif.Top100Data;

public  interface IGoogleSheetsHelper
{
    SheetsService Service { get; set; }
}
