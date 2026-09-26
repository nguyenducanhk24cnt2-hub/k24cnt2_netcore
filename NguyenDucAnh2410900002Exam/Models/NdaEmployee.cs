using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NguyenDucAnh2410900002Exam.Models;

public partial class NdaEmployee
{
    [Key]
    public int Id { get; set; }

    public string NdaName { get; set; } = null!;

    public string NdaGender { get; set; } = null!;

    public DateOnly NdaBirthDay { get; set; }

    public string NdaEmail { get; set; } = null!;

    public string? NdaPhone { get; set; }

    public bool NdaActive { get; set; }
}
