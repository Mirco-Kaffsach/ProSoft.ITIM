namespace ProSoft.ITIM.Core.Models;

/// <summary>
/// Class Floor. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Floor : IDisposable
{
   public List<Room> Rooms { get; set; } = [];

   public List<OfficeSpace> OfficeSpaces { get; set; } = [];

   #region IDisposable Implementation

   private bool _isDisposed;

   /// <summary>
   /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
   /// </summary>
   public void Dispose()
   {
      Dispose(true);
      GC.SuppressFinalize(this);
   }

   /// <summary>
   /// Releases unmanaged and - optionally - managed resources.
   /// </summary>
   /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
   public void Dispose(bool disposing)
   {
      if (_isDisposed == false)
      {
         if (disposing)
         {
            // Dispose managed state (managed objects).
         }

         // Free unmanaged resources (unmanaged objects) and override a finalizer below.
         // Set large fields to null.

         _isDisposed = true;
      }

      // Call base class implementation.
   }

   /// <summary>
   /// Finalizes an instance of the <see cref="Floor"/> class.
   /// </summary>
   ~Floor() => Dispose(false);

   #endregion
}
