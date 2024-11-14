﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using ProSoft.Results;

namespace ProSoft.ITIM.WebApi.Controllers;

[Route("health")]
[ApiController]
[Produces("application/json")]
public class HealthController : ControllerBase, IDisposable
{
   private readonly ILogger<HealthController> _logger;

   public HealthController(ILogger<HealthController> logger)
   {
      _logger = logger;

      if (_logger.IsEnabled(LogLevel.Debug))
      {
         _logger.LogDebug("{ControllerName} initialized successfully.", nameof(HealthController));
      }
   }

   [HttpGet]
   public async Task<Result<string>> CheckUpStatusAsync(CancellationToken cancellationToken)
   {
      _logger.LogDebug("/health called");
      await Task.CompletedTask;

      return new Result<string>
      {
         Type = ResultType.Success,
         Value = "OK",
         Messages = new HashSet<MessageItem>
         {
            new MessageItem(MessageType.Information, "Cool")
         }
      };
   }

   #region IDisposable Interface Implementation

   private bool _isDisposed;

   /// <summary>
   /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
   /// </summary>
   /// <autogeneratedoc />
   [ExcludeFromCodeCoverage]
   public void Dispose()
   {
      this.Dispose(true);
      GC.SuppressFinalize(this);
   }

   /// <summary>
   /// Releases unmanaged and - optionally - managed resources.
   /// </summary>
   /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
   /// <autogeneratedoc />
   [ExcludeFromCodeCoverage]
   protected virtual void Dispose(bool disposing)
   {
      if (!_isDisposed && disposing)
      {
         // Disposing Logic
      }

      _isDisposed = true;
   }


   /// <summary>
   /// Finalizes an instance of the <see cref="HealthController"/> class.
   /// </summary>
   /// <autogeneratedoc />
   [ExcludeFromCodeCoverage]
   ~HealthController()
   {
      this.Dispose(false);
   }

   #endregion
}
