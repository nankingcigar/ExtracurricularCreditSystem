using Abp;
using System;

namespace Nankingcigar.CEC.Core.Entity
{
  public sealed class ApiException : Exception, IHasErrorCode
  {
    public int Code { get; set; }

    public ApiException(int code)
    {
      Code = code;
    }

    public ApiException(int code, string message)
            : base(message)
    {
      Code = code;
    }

    public ApiException(int code, string message, Exception innerException)
            : base(message, innerException)
    {
      Code = code;
    }
  }
}