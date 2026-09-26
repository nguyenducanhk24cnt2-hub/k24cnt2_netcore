using System;
using System.Collections.Generic;

namespace NdaFirstDatabase.Models;

public partial class NdaEmployee
{
    public int Id { get; set; }

    public string NdaName { get; set; } = null!;

    public string NdaGender { get; set; } = null!;

    public DateOnly NdaBirthDay { get; set; }

    public string NdaEmail { get; set; } = null!;

    public string? NdaPhone { get; set; }

    public bool NdaActive { get; set; }
}
