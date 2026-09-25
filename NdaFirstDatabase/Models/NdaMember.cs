using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NdaFirstDatabase.Models;

public partial class NdaMember
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long NdaId { get; set; }

    public string? NdaUserName { get; set; }

    public string? NdaPassword { get; set; }

    public string? NdaFullName { get; set; }

    public string? NdaEmail { get; set; }

    public string? NdaPhone { get; set; }

    public bool? NdaStatus { get; set; }
}
