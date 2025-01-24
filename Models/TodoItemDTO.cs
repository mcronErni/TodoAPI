using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        [Key]
        public long ItemId { get; set; }
        public string? Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
