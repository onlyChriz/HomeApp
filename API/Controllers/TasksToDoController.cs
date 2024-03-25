using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HomeApp.API.Models;
using HomeApp.API.Data;
using HomeApp.API.Interfaces;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HomeApp.API.Controllers
{
    [ApiController]

    public class TasksToDoController : ControllerBase
    {

        private readonly ITaskRepository task;


        public TasksToDoController(ITaskRepository task)
        {
            this.task = task;

        }

        [HttpGet]
        [Route("[controller]/GetAll")]
        public async Task<ActionResult<TasksToDo>> GetAllTasks()
        {
            if (task.GetAllTasks() == null)
                return NotFound();

            return Ok(task.GetAllTasks());
        }

        [HttpGet]
        [Route("[controller]/GetTaskById/{id}")]
        public async Task<ActionResult<TasksToDo>> GetTaskById(int id)
        {
            if (task.TaskExist(id) == false)
                return NotFound();
            return Ok(task.GetTaskById(id));
        }

        [HttpPost]
        [Route("[controller]/Post")]
        public async Task<ActionResult<TasksToDo>> CreateTask(TasksToDo toDoTask)
        {
            return Ok(task.CreateTask(toDoTask));
        }

        [HttpPut]
        [Route("[controller]/Put/{id}")]
        public async Task<ActionResult<TasksToDo>> UpdateTask(int id, TasksToDo toDoTask)
        {
            if(task.TaskExist(id) == false)
                return NotFound();

            var foundTask = task.GetTaskById(id);
             
            foundTask.Name = toDoTask.Name;
            foundTask.Description = toDoTask.Description;
            foundTask.Date = toDoTask.Date;
            

            if(task.UpdateTask(foundTask))
                return Ok(foundTask);
            return BadRequest();

        }

        [HttpDelete]
        [Route("[controller]/Delete/{id}")]
        public async Task<ActionResult<TasksToDo>> DeleteTask(int id)
        {
            return Ok(task.DeleteTask(id));
        }


    }
}
