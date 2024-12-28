using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCopy.Wif.Top100Data;

internal class GoogleSheetsService(IOptions<Top100DataOptions> options) : IGoogleSheetsService
{
    public string ToList()
    {
        throw new NotImplementedException();
    }

    public T ToList<T>()
    {
        throw new NotImplementedException();
    }
}
