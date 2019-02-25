# SAMP-API
A C# written API to GTA:SA and SA:MP (works on all recent versions including 0.3.DL) using memory injections

A lot of credit is owed to this project: https://github.com/SAMP-UDF/SAMP-UDF-for-AutoHotKey/
In fact, this library is mostly a translation of their AHK script to C#

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
