namespace UI.Models
{
    public class TaskModel
    {
        public IEnumerable<ToDoTask> Tasks { get; set; }
    }

    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsCompleted { get; set; }
    }

}
