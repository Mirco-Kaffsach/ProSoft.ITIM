using System.Net;
using Ardalis.GuardClauses;
using ProSoft.ITIM.Core.Models;

namespace ProSoft.ITIM.Core.Extensions;

public static class IPv4Extensions
{
   public static IPv4Address ToIPv4Address(this string ipstring)
   {
      Guard.Against.NullOrWhiteSpace(ipstring);

      var validInput = IPAddress.TryParse(ipstring, out var address);

      if (validInput == false || address == null)
         throw new ArgumentOutOfRangeException(nameof(ipstring), "Invalid ip address");

      return address.GetAddressBytes().ToIPv4Address();
   }

   public static IPv4Address ToIPv4Address(this IList<byte> input)
   {
      Guard.Against.Null(input);
      Guard.Against.OutOfRange(input.Count, nameof(input), 4, 4, "Invalid ip address");

      _ = new IPAddress(input.ToArray());

      return new IPv4Address(input[0], input[1], input[2], input[3]);
   }

   public static string ToString(this IPv4Address input)
   {
      Guard.Against.Null(input);

      return $"{input.Octet1}.{input.Octet2}.{input.Octet3}.{input.Octet4}";
   }
}
