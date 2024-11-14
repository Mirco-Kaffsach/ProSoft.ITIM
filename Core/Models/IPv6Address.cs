namespace ProSoft.ITIM.Core.Models;

/// <summary>
/// Class IPv6Address. This class cannot be inherited.
/// Implements the <see cref="System.IEquatable`1" />
/// </summary>
/// <seealso cref="System.IEquatable`1" />
public record struct IPv6Address
{
   /// <summary>
   /// Initializes a new instance of the <see cref="IPv6Address"/> struct.
   /// </summary>
   /// <param name="octet1">The octet1.</param>
   /// <param name="octet2">The octet2.</param>
   /// <param name="octet3">The octet3.</param>
   /// <param name="octet4">The octet4.</param>
   /// <param name="octet5">The octet5.</param>
   /// <param name="octet6">The octet6.</param>
   /// <param name="octet7">The octet7.</param>
   /// <param name="octet8">The octet8.</param>
   public IPv6Address(
      ushort octet1,
      ushort octet2,
      ushort octet3,
      ushort octet4,
      ushort octet5,
      ushort octet6,
      ushort octet7,
      ushort octet8)
   {
      Octet1 = octet1;
      Octet2 = octet2;
      Octet3 = octet3;
      Octet4 = octet4;
      Octet5 = octet5;
      Octet6 = octet6;
      Octet7 = octet7;
      Octet8 = octet8;
   }

   /// <summary>
   /// Gets or sets the octet1.
   /// </summary>
   /// <value>The octet1.</value>
   public ushort Octet1 { get; set; }

   /// <summary>
   /// Gets or sets the octet2.
   /// </summary>
   /// <value>The octet2.</value>
   public ushort Octet2 { get; set; }

   /// <summary>
   /// Gets or sets the octet3.
   /// </summary>
   /// <value>The octet3.</value>
   public ushort Octet3 { get; set; }

   /// <summary>
   /// Gets or sets the octet4.
   /// </summary>
   /// <value>The octet4.</value>
   public ushort Octet4 { get; set; }

   /// <summary>
   /// Gets or sets the octet5.
   /// </summary>
   /// <value>The octet5.</value>
   public ushort Octet5 { get; set; }

   /// <summary>
   /// Gets or sets the octet6.
   /// </summary>
   /// <value>The octet6.</value>
   public ushort Octet6 { get; set; }

   /// <summary>
   /// Gets or sets the octet7.
   /// </summary>
   /// <value>The octet7.</value>
   public ushort Octet7 { get; set; }

   /// <summary>
   /// Gets or sets the octet8.
   /// </summary>
   /// <value>The octet8.</value>
   public ushort Octet8 { get; set; }

   /// <summary>
   /// Deconstructs the specified octet1.
   /// </summary>
   /// <param name="octet1">The octet1.</param>
   /// <param name="octet2">The octet2.</param>
   /// <param name="octet3">The octet3.</param>
   /// <param name="octet4">The octet4.</param>
   /// <param name="octet5">The octet5.</param>
   /// <param name="octet6">The octet6.</param>
   /// <param name="octet7">The octet7.</param>
   /// <param name="octet8">The octet8.</param>
   public readonly void Deconstruct(
      out ushort octet1,
      out ushort octet2,
      out ushort octet3,
      out ushort octet4,
      out ushort octet5,
      out ushort octet6,
      out ushort octet7,
      out ushort octet8)
   {
      octet1 = this.Octet1;
      octet2 = this.Octet2;
      octet3 = this.Octet3;
      octet4 = this.Octet4;
      octet5 = this.Octet5;
      octet6 = this.Octet6;
      octet7 = this.Octet7;
      octet8 = this.Octet8;
   }
}
