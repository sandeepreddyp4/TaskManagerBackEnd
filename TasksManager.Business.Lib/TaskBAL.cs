using System.Collections.Generic;
using System.Linq;
using TaskManager.Entities;
using TasksManager.Data.Lib;

namespace TasksManager.Business.Lib
{
    public class TaskBAL
    {
        public void Add(Task taskItem)
        {
            using (TaskManagerContext taskManagerContext = new TaskManagerContext())
            {
                taskManagerContext.Tasks.Add(taskItem);
                taskManagerContext.SaveChanges();
            }
        }

        public List<Task> GetAllTasks()
        {
            using (TaskManagerContext taskManagerContext = new TaskManagerContext())
            {
                return taskManagerContext.Tasks.ToList();
            }
        }

        public Task GetTaskById(int taskId)
        {
            using (TaskManagerContext taskManagerContext = new TaskManagerContext())
            {
                return taskManagerContext.Tasks.FirstOrDefault(k => k.TaskId == taskId);
            }
        }

    }
}
