﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hos.ScheduleMaster.Core.Models
{
    [Table("schedulelocks")]
    public class ScheduleLockEntity : IEntity
    {
        [Key]
        [Column("scheduleid", TypeName = "varchar(36)")]
        public Guid ScheduleId { get; set; }

        [Required]
        [Column("status")]
        public int Status { get; set; }

        [Column("lockedtime")]
        public  DateTime? LockedTime { get; set; }

        [Column("lockednode", TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string LockedNode { get; set; }
    }

}
