using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Nankingcigar.CEC.Core.Entity.POCO
{
  public sealed class AuditLog : Entity<long>
  {
    private const int SERVICENAME_LENGTH = 256;
    private const int METHODNAME_LENGTH = 256;
    private const int PARAMETERS_LENGTH = 2 ^ 10;
    private const int CLIENTIPADDRESS_LENGTH = 64;
    private const int CLIENTNAME_LENGTH = 128;
    private const int BROWSERINFO_LENGTH = 256;
    private const int EXCEPTION_LENGTH = 2000;
    private const int CUSTOMDATA_LENGTH = 2000;

    [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AuditLog()
    {
    }

    public long? UserId { get; set; }

    [StringLength(SERVICENAME_LENGTH)]
    public string ServiceName { get; set; }

    [StringLength(METHODNAME_LENGTH)]
    public string MethodName { get; set; }

    [StringLength(PARAMETERS_LENGTH)]
    public string Parameters { get; set; }

    public DateTime ExecutionTime { get; set; }
    public int ExecutionDuration { get; set; }

    [StringLength(CLIENTIPADDRESS_LENGTH)]
    public string ClientIpAddress { get; set; }

    [StringLength(CLIENTNAME_LENGTH)]
    public string ClientName { get; set; }

    [StringLength(BROWSERINFO_LENGTH)]
    public string BrowserInfo { get; set; }

    [StringLength(EXCEPTION_LENGTH)]
    public string Exception { get; set; }

    public long? ImpersonatorUserId { get; set; }

    [StringLength(CUSTOMDATA_LENGTH)]
    public string CustomData { get; set; }

    public static AuditLog CreateFromAuditInfo(AuditInfo auditInfo)
    {
      var exceptionMessage = auditInfo.Exception?.ToString();
      return new AuditLog
      {
        UserId = auditInfo.UserId,
        ServiceName = auditInfo.ServiceName.TruncateWithPostfix(SERVICENAME_LENGTH),
        MethodName = auditInfo.MethodName.TruncateWithPostfix(METHODNAME_LENGTH),
        Parameters = auditInfo.Parameters.TruncateWithPostfix(PARAMETERS_LENGTH),
        ExecutionTime = auditInfo.ExecutionTime,
        ExecutionDuration = auditInfo.ExecutionDuration,
        ClientIpAddress = auditInfo.ClientIpAddress.TruncateWithPostfix(CLIENTIPADDRESS_LENGTH),
        ClientName = auditInfo.ClientName.TruncateWithPostfix(CLIENTNAME_LENGTH),
        BrowserInfo = auditInfo.BrowserInfo.TruncateWithPostfix(BROWSERINFO_LENGTH),
        Exception = auditInfo.Exception?.ToString().TruncateWithPostfix(EXCEPTION_LENGTH),
        ImpersonatorUserId = auditInfo.ImpersonatorUserId,
        CustomData = auditInfo.CustomData.TruncateWithPostfix(CUSTOMDATA_LENGTH)
      };
    }
  }
}