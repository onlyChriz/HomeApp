using HomeApp.API.Data;
using HomeApp.API.Interfaces;
using HomeApp.API.Models;

namespace HomeApp.API.TaskRepository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly HomeAppContext Context;
        public TaskRepository(HomeAppContext context)
        {
            Context = context;
        }
        public bool CreateTask(ToDoTask task)
        {
            Context.Add(task);
            return Save();
        }

        public bool DeleteTask(ToDoTask toDoTask)
        {
            Context.ToDoTask.Remove(toDoTask);
            return Save();
        }

        public ICollection<ToDoTask> GetAllTasks()
        {
            return Context.ToDoTask.OrderBy(t => t.Id).ToList();
        }

        public ToDoTask GetTaskById(int id)
        {
            return Context.ToDoTask.Where(t => t.Id == id).FirstOrDefault();     }


        public bool UpdateTask(ToDoTask task)
        {
            Context.Update(task);
            return Save();
        }
        public bool Save()
        {
            var saved = Context.SaveChanges();
            return saved > 0? true: false;
        }

        public bool TaskExist(int id)
        {
            return Context.ToDoTask.Any(t => t.Id == id);
        }
    }
}
