using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Diplom.Models;

public partial class Taskforrequest
{
    public int TaskCode { get; set; }

    public int? OrganizationCode { get; set; }

    public int? RequestId { get; set; }

    public DateOnly? DateOfReceipt { get; set; }

    public string? TaskStatus { get; set; }

    public string? TaskDeadline { get; set; }

    public int? IdPartner { get; set; }
    [JsonIgnore]
    public virtual User? IdPartnerNavigation { get; set; }
    [JsonIgnore]
    public virtual Request? Request { get; set; }
}
