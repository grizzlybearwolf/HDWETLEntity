using System;
using System.ComponentModel.DataAnnotations;


namespace HDWETLEntity.Poco.Models
{
    public class ETLScheduleLog
    {
        [Key]
        public int Id { get; set; }        
        public string ProcessName { get; set; }
        public DateTime ExecuteStart { get; set; }
        public DateTime? ExecuteEnd { get; set; }
        public string State { get; set; }

        public int ETLScheduleId { get; set; }
        public virtual ETLSchedule ETLSchedule { get; set; }
    }
}
