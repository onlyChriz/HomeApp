using HomeApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeApp.API.Interfaces
{
    public interface IToDoTasksController
    {
        Task<ActionResult<TasksToDo>> CreateTask(TasksToDo task);
        Task<ActionResult<IEnumerable<TasksToDo>>> GetAllTasks();
        Task<ActionResult<TasksToDo>> GetTaskById(int id);
        Task<ActionResult<TasksToDo>> UpdateTask(int id, TasksToDo toDoTask);
        Task<ActionResult<TasksToDo>> DeleteTask(int id);
    }
}