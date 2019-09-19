using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TasksManager.Business.Lib;
using TaskManager.Entities;

namespace TaskManagerApi.Controllers
{
    public class TaskController : ApiController
    {
        [Route("GetAll")]
        public IHttpActionResult Get()
        {
            TaskBAL tskBL = new TaskBAL();
            return Ok(tskBL.GetAllTasks());
        }

        [Route("GetTaskById/{taskId}")]
        public IHttpActionResult GetTaskById([FromUri] int taskId)
        {
            TaskBAL tskBL = new TaskBAL();
            return Ok(tskBL.GetTaskById(taskId));
        }

        [Route("Post")]
        public IHttpActionResult POST([FromBody] Task task)
        {
            TaskBAL tskBL = new TaskBAL();
            tskBL.Add(task);
            return Ok("Task created successfully");
        }
    }
}
