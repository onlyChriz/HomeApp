using HomeApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HomeApp.API.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<TasksToDo> GetAllTasks();
        TasksToDo GetTaskById(int id);
        bool CreateTask(TasksToDo task);
        bool UpdateTask(TasksToDo toDoTask);
        bool DeleteTask(int id);
        bool TaskExist(int id);
        bool Save();
    }
}
