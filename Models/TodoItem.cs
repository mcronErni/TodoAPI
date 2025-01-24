using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        [Key]
        public long ItemId { get; set; }
        public string? Name { get; set; }
        public string? Secret { get; set; }
        public bool IsCompleted { get; set; }
    }
}
