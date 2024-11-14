namespace ProSoft.ITIM.Core.Models;

/// <summary>
/// Class IPv4Address. This class cannot be inherited.
/// Implements the <see cref="System.IEquatable`1" />
/// </summary>
/// <seealso cref="System.IEquatable`1" />
public record struct IPv4Address
{
   /// <summary>
   /// Initializes a new instance of the <see cref="IPv4Address"/> struct.
   /// </summary>
   /// <param name="octet1">The octet1.</param>
   /// <param name="octet2">The octet2.</param>
   /// <param name="octet3">The octet3.</param>
   /// <param name="octet4">The octet4.</param>
   public IPv4Address(byte octet1, byte octet2, byte octet3, byte octet4)
   {
      this.Octet1 = octet1;
      this.Octet2 = octet2;
      this.Octet3 = octet3;
      this.Octet4 = octet4;
   }

   /// <summary>
   /// Gets or sets the octet1.
   /// </summary>
   /// <value>The octet1.</value>
   public byte Octet1 { get; set; }

   /// <summary>
   /// Gets or sets the octet2.
   /// </summary>
   /// <value>The octet2.</value>
   public byte Octet2 { get; set; }

   /// <summary>
   /// Gets or sets the octet3.
   /// </summary>
   /// <value>The octet3.</value>
   public byte Octet3 { get; set; }

   /// <summary>
   /// Gets or sets the octet4.
   /// </summary>
   /// <value>The octet4.</value>
   public byte Octet4 { get; set; }

   /// <summary>
   /// Deconstructs the specified octet1.
   /// </summary>
   /// <param name="octet1">The octet1.</param>
   /// <param name="octet2">The octet2.</param>
   /// <param name="octet3">The octet3.</param>
   /// <param name="octet4">The octet4.</param>
   public readonly void Deconstruct(out byte octet1, out byte octet2, out byte octet3, out byte octet4)
   {
      octet1 = this.Octet1;
      octet2 = this.Octet2;
      octet3 = this.Octet3;
      octet4 = this.Octet4;
   }
}
