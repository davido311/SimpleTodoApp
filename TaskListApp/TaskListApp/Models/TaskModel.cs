using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskListApp.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int IdTask { get; set; }
        [Required(ErrorMessage ="Please enter name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
