using FileCopy.Wif.Models;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Options;

namespace FileCopy.Wif.Top100Data.GoogleSheet;

internal class GoogleSheetsService(IGoogleSheetsHelper googleSheetsHelper, IOptions<Top100DataOptions> options) : IGoogleSheetsService
{
    private readonly Top100DataOptions _option = options.Value;
    private SpreadsheetsResource.ValuesResource _googleSheetValues;
    
    public List<TrackData> ToList()
    {
        _googleSheetValues = googleSheetsHelper.Service.Spreadsheets.Values;

        var range = $"{_option.SHEET_NAME}!A:C";
        var request = _googleSheetValues.Get(_option.SPREADSHEET_ID, range);
        var response = request.Execute();
        var values = response.Values.Skip(3);


        var returnValue = new List<TrackData>();
        foreach (var value in values)
        {
            _ = int.TryParse(value[0].ToString(), out int position);
            TrackData trackData = new()
            {
                Position = position,
                Artist = value[1].ToString(),
                Title = value[2].ToString()
            };

            returnValue.Add(trackData);
        }
        return returnValue;
    }
}
