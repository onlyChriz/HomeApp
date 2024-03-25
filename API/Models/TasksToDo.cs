using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HomeApp.API.Models
{
    public class TasksToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? Date { get; set; }
        public bool IsDone { get; set; } = false;

    }
}
