using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
      Console.WriteLine($"JsonToken: {token}");

      var handler = new JwtSecurityTokenHandler();
      var jsonToken = handler.ReadToken(token);

      Console.WriteLine($"JsonToken: {jsonToken}");


      var tokenS = jsonToken as JwtSecurityToken;

      var claims = tokenS.Claims;

      foreach (Claim claim in claims)
      {
        Console.WriteLine($"{claim.Type}: {claim.Value}");
      }

      Console.Read();

    }
  }
}
