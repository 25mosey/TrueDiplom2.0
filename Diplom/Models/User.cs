using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Diplom.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public DateOnly? DateBirth { get; set; }

    public string? UserInn { get; set; }

    public int? Role { get; set; }

    public string? UserInfo { get; set; }

    public string? UserProfile { get; set; }

    public string? UserOrgName { get; set; }

    public string? UserStatus { get; set; }
    [JsonIgnore]
    public virtual ICollection<Contract> ContractOrganisations { get; set; } = new List<Contract>();
    [JsonIgnore]
    public virtual ICollection<Contract> ContractPartners { get; set; } = new List<Contract>();
    [JsonIgnore]
    public virtual ICollection<News> News { get; set; } = new List<News>();
    [JsonIgnore]
    public virtual ICollection<Request> RequestPartners { get; set; } = new List<Request>();
    [JsonIgnore]
    public virtual ICollection<Request> RequestUsers { get; set; } = new List<Request>();
    [JsonIgnore]
    public virtual Role? RoleNavigation { get; set; }
    [JsonIgnore]
    public virtual ICollection<Taskforrequest> Taskforrequests { get; set; } = new List<Taskforrequest>();
}
