﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjMSIT158API8.Models;

public partial class TEventLog
{
    public int EventId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ProductId { get; set; }

    public string EventDateTime { get; set; }

    public string EventBrief { get; set; }

    public virtual TEmployee Employee { get; set; }
}