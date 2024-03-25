using HomeApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeApp.API.Interfaces
{
    public interface IToDoTasksController
    {
        Task<ActionResult<ToDoTask>> CreateTask(ToDoTask task);
        Task<ActionResult<IEnumerable<ToDoTask>>> GetAllTasks();
        Task<ActionResult<ToDoTask>> GetTaskById(int id);
        Task<ActionResult<ToDoTask>> UpdateTask(int id, ToDoTask toDoTask);
        Task<ActionResult<ToDoTask>> DeleteTask(int id);
    }
}