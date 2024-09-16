using System.Diagnostics.CodeAnalysis;

namespace ProSoft.ITIM.Logic.Contracts.Exceptions;

/// <summary>
/// Class LogicException.
/// Implements the <see cref="System.Exception" />
/// </summary>
/// <seealso cref="System.Exception" />
[ExcludeFromCodeCoverage]
[Serializable]
public class LogicException : Exception
{
   /// <summary>
   /// Initializes a new instance of the <see cref="LogicException"/> class.
   /// </summary>
   public LogicException()
   {
      
   }

   /// <summary>
   /// Initializes a new instance of the <see cref="LogicException"/> class.
   /// </summary>
   /// <param name="message">The message that describes the error.</param>
   public LogicException(string message) : base(message)
   {
   }

   /// <summary>
   /// Initializes a new instance of the <see cref="LogicException"/> class.
   /// </summary>
   /// <param name="message">The error message that explains the reason for the exception.</param>
   /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<see langword="Nothing" /> in Visual Basic) if no inner exception is specified.</param>
   public LogicException(string message, Exception innerException) : base(message, innerException)
   {
   }
}
