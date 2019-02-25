using System;
using GtaSampApi;

namespace SampApiSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampApi.AddMessageToChat("{FFFFFF}SAMP {FF0000}API {00FF00}sample");

            SampApi.AddMessageToChat(
                $"You are in {SampApi.GetPlayerCurrentZone()} with facing angle {SampApi.GetPlayerFacingAngle():F1}");
            SampApi.AddMessageToChat(
                "Sample text");

            Console.ReadLine();
        }
    }
}
