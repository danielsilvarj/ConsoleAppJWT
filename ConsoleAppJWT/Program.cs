using JWT.Algorithms;
using JWT.Builder;
using System;
using System.Collections.Generic;

namespace ConsoleAppJWT
{
    class Program
    {
        static void Main(string[] args)
        {
            const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
            #region Create otken
            var payload = new Dictionary<string, object>
            {
                { "claim1", 0 },
                { "claim2", "claim2-value" }
            };
            
            var token = new JwtBuilder()
              .WithAlgorithm(new HMACSHA256Algorithm())
              .WithSecret(secret)
              .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
              .AddClaim("claim2", "claim2-value")
              .Build();


            Console.WriteLine(token);
            Console.ReadKey();
            #endregion
            Console.WriteLine("Hello World!");

            
        }
    }
}
