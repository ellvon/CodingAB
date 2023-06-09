﻿using System.ComponentModel.DataAnnotations;

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingAB.Models
{
    public class TimeOffRequest
    {
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeOffType Type { get; set; }
        public DateTime RequestSubmissionTime { get; set; }
    }
}
