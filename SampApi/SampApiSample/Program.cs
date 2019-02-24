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
