using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Diplom.Models;

public partial class News
{
    public int NewsId { get; set; }

    public string? NewsTitle { get; set; }

    public string? NewsText { get; set; }

    public DateOnly? NewsUpdateDate { get; set; }

    public DateOnly? NewsPublichDate { get; set; }

    public string? NewsPublisher { get; set; }

    public int AdminId { get; set; }
    [JsonIgnore]
    public virtual User? Admin { get; set; }
}
