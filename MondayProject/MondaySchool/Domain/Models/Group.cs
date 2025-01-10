using System;

namespace Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public DateTime ScheduleTime { get; set; }
        
        public int LessonTypeId { get; set; }
        public LessonType? LessonType { get; set; }
        
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
    }
}