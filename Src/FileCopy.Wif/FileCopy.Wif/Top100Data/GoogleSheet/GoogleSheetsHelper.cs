using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Options;


namespace FileCopy.Wif.Top100Data.GoogleSheet;

public class GoogleSheetsHelper : IGoogleSheetsHelper
{
    private readonly Top100DataOptions _option;
    public SheetsService Service { get; set; }

    const string APPLICATION_NAME = "Zell Catalogs";
    static readonly string[] Scopes = [SheetsService.Scope.Spreadsheets];

    public GoogleSheetsHelper(IOptions<Top100DataOptions> options)
    {
        _option = options.Value;

        var credential = GetCredentialsFromFile(_option.SheetKey);

        Service = new SheetsService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = _option.ApplicationName
        });
    }

    private static GoogleCredential GetCredentialsFromFile(string sheetKeyFile)
    {
        GoogleCredential credential;
        using (var stream = new FileStream(sheetKeyFile, FileMode.Open, FileAccess.Read))
        {
            credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
        }

        return credential;
    }
}
