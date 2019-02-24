# SAMP-API
A C# written API to GTA:SA and SA:MP (using memory injection)
A lot of credit goes to this project: https://github.com/SAMP-UDF/SAMP-UDF-for-AutoHotKey/
This library is mostly a translation of their AHK script to a C# library

### Example
```C#
using System;

namespace SampApiSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampApi.SampApi.AddMessageToChat("{FFFFFF}SAMP {FF0000}API {00FF00}sample");

            SampApi.SampApi.AddMessageToChat(
                $"You are in {SampApi.SampApi.GetPlayerCurrentZone()} with facing angle {SampApi.SampApi.GetPlayerFacingAngle():F1}");

            Console.ReadLine();
        }
    }
}

```
