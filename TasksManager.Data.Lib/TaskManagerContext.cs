using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TaskManager.Entities;

namespace TasksManager.Data.Lib
{
    public class TaskManagerContext:DbContext
    {
        public TaskManagerContext() : base("name=TaskManagerConnection")
        {

        }

        public DbSet<TaskManager.Entities.Task> Tasks { get; set; }
    }
}
