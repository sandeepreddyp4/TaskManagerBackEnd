using System;

namespace TaskManager.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int Priority { get; set; }
        public DateTime SDate { get; set; }
        public DateTime EDate { get; set; }
    }
}
