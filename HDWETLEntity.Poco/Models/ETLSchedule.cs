using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HDWETLEntity.Poco.Models
{
    public class ETLSchedule
    {
        [Key]
        public int ETLScheduleId { get; set; }

        [Required]
        public string Name { get; set; }
        public int? Period { get; set; }
        public DateTime? TriggerTime { get; set; }
        public DateTime? LastTriggered { get; set; }
        public int? Frequency { get; set; }

        public virtual ICollection<ETLScheduleLog> ETLScheduleLogs { get; set; }
    }
}
