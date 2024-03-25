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
    [Route("api/[controller]")]
    public class ToDoTasksController : ControllerBase
    {
        private readonly ITaskRepository task;


        public ToDoTasksController(ITaskRepository task)
        {
            this.task = task;

        }

        [HttpGet]
        [Route("[controller]/GetAll")]
        public async Task<ActionResult<ToDoTask>> GetAllTasks()
        {
            if (task.GetAllTasks() == null)
                return NotFound();

            return Ok(task.GetAllTasks());
        }

        [HttpGet]
        [Route("[controller]/GetTaskById/{id}")]
        public async Task<ActionResult<ToDoTask>> GetTaskById(int id)
        {
            if (task.TaskExist(id) == false)
                return NotFound();
            return Ok(task.GetTaskById(id));
        }

        [HttpPost]
        [Route("[controller]/Post")]
        public async Task<ActionResult<ToDoTask>> CreateTask(ToDoTask toDoTask)
        {
            return Ok(task.CreateTask(toDoTask));
        }

        [HttpPut]
        [Route("[controller]/Put/{id}")]
        public async Task<ActionResult<ToDoTask>> UpdateTask(int id, ToDoTask toDoTask)
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
        public async Task<ActionResult<ToDoTask>> DeleteTask(int id)
        {
            var foundTask = task.GetTaskById(id);

            return Ok(task.DeleteTask(foundTask));
        }


    }
}
