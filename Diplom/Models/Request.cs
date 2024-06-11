using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Diplom.Models;

public partial class Request
{
    public int RequestId { get; set; }

    public string? SupplierStatus { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanySite { get; set; }

    public string? UserName { get; set; }

    public string? StuffName { get; set; }

    public ulong? IsForLifeSupport { get; set; }

    public string? TypeRequest { get; set; }

    public int? PostAddress { get; set; }

    public string? CoordAddress { get; set; }

    public string? LiableName { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPhone { get; set; }

    public string? AdditionalInformation { get; set; }

    public string? Region { get; set; }

    public DateOnly? DateRequestStart { get; set; }

    public DateOnly? DateRequestEnd { get; set; }

    public DateOnly? DateRequestPrice { get; set; }

    public DateOnly? DateEnd { get; set; }

    public double? Price { get; set; }

    public string? PriceCurrency { get; set; }

    public string? IkzCode { get; set; }

    public DateOnly? DateContractStart { get; set; }

    public ulong? IsCompanyMoney { get; set; }

    public int? PartnerId { get; set; }

    public int? UserId { get; set; }
    [JsonIgnore]
    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
    [JsonIgnore]
    public virtual User? Partner { get; set; }
    [JsonIgnore]
    public virtual ICollection<Taskforrequest> Taskforrequests { get; set; } = new List<Taskforrequest>();
    [JsonIgnore]
    public virtual User? User { get; set; }
}
