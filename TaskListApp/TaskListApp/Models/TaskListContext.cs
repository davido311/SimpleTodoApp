using Microsoft.EntityFrameworkCore;

namespace TaskListApp.Models
{
    public class TaskListContext : DbContext
    {
        public TaskListContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
    }


   
}
