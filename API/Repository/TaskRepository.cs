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
        public bool CreateTask(TasksToDo task)
        {
            Context.Add(task);
            return Save();
        }

        public bool DeleteTask(int id)
        {
            var task = GetTaskById(id);
            if (task == null)
            {
                return false;
            }

            Context.Remove(task);
            return Save();
        }

        public IEnumerable<TasksToDo> GetAllTasks()
        {
            return Context.ToDoTask.OrderBy(t => t.Id).ToList();
        }

        public TasksToDo GetTaskById(int id)
        {
            return Context.ToDoTask.Where(t => t.Id == id).FirstOrDefault();     
        }


        public bool UpdateTask(TasksToDo task)
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
