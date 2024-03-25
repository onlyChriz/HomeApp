using HomeApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HomeApp.API.Interfaces
{
    public interface ITaskRepository
    {
        ICollection<ToDoTask> GetAllTasks();
        ToDoTask GetTaskById(int id);
        bool CreateTask(ToDoTask task);
        bool UpdateTask(ToDoTask toDoTask);
        bool DeleteTask(ToDoTask toDoTask);
        bool TaskExist(int id);
        bool Save();
    }
}
