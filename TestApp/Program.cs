using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.Business.Lib;
using TaskManager.Entities;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskBAL tskBL = new TaskBAL();
            tskBL.Add(new TaskManager.Entities.Task(){TaskId=1234,TaskName="first task",Priority=1,SDate=DateTime.Now,EDate=DateTime.Now});
        }
    }
}
