using System.Net;
using System.Net.Sockets;
using Ardalis.GuardClauses;
using ProSoft.ITIM.Core.Models;

namespace ProSoft.ITIM.Core.Extensions;

public static class IPv6Extensions
{
   public static IPv6Address ToIPv6Address(this string ipstring)
   {
      Guard.Against.NullOrWhiteSpace(ipstring);

      var validInput = IPAddress.TryParse(ipstring, out var address);

      if (validInput == false || address == null)
         throw new ArgumentOutOfRangeException(nameof(ipstring), "Invalid ip address");

      return address.ToIPv6Address();
   }

   public static IPv6Address ToIPv6Address(this IPAddress input)
   {
      Guard.Against.Null(input);
      
      if (input.AddressFamily != AddressFamily.InterNetworkV6)
         throw new ArgumentException("Invalid IPv6 address.", nameof(input));

      var test = input.ToString();

      return new IPv6Address(1, 1, 1, 1, 1, 1, 1, 1);
   }

   public static IPv6Address ToIPv6Address(this IList<ushort> input)
   {
      Guard.Against.Null(input);
      Guard.Against.OutOfRange(input.Count, nameof(input), 8, 8, "Invalid ip address");

      return new IPv6Address
      (
         input[0],
         input[1],
         input[2],
         input[3],
         input[4],
         input[5],
         input[6],
         input[7]
      );
   }

   public static string ToString(this IPv4Address input)
   {
      Guard.Against.Null(input);

      return $"{input.Octet1}.{input.Octet2}.{input.Octet3}.{input.Octet4}";
   }
}
