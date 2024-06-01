﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models;

[Index("CustomerId", Name = "IX_CreditRisks_CustomerId")]
public partial class CreditRisk
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    public int CustomerId { get; set; }

    public byte[]? TimeStamp { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CreditRisks")]
    public virtual Customer Customer { get; set; } = null!;
}
