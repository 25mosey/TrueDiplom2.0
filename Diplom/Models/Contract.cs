using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Diplom.Models;

public partial class Contract
{
    public int IdContract { get; set; }

    public int? RequestId { get; set; }

    public string? ContractStatus { get; set; }

    public string? UserName { get; set; }

    public string? StuffName { get; set; }

    public int? IkzCode { get; set; }

    public DateOnly? DateRequestStart { get; set; }

    public DateOnly? DateContractStart { get; set; }

    public int? PartnerId { get; set; }

    public int? OrganisationId { get; set; }
    [JsonIgnore]
    public virtual User? Organisation { get; set; }
    [JsonIgnore]
    public virtual User? Partner { get; set; }
    [JsonIgnore]
    public virtual Request? Request { get; set; }
}
