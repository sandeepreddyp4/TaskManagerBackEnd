using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Entities
{
    [Table("task")]
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [StringLength(30)]
        public string TaskName { get; set; }
        public int Priority { get; set; }

        [Column (TypeName ="Date")]
        public DateTime SDate { get; set; }

        [Column (TypeName ="Date")]
        public DateTime EDate { get; set; }
    }
}
