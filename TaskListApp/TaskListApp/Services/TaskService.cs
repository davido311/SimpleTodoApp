using System.Linq;
using TaskListApp.Models;

namespace TaskListApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskListContext _context;
        public TaskService(TaskListContext context)
        {
            _context = context;
        }
        public void Add(TaskModel taskModel)
        {
            _context.Tasks.Add(taskModel);
            _context.SaveChanges();
        }

        public void Delete(int taskId)
        {
            var result = _context.Tasks.SingleOrDefault(e=>e.IdTask == taskId);
            if(result != null)
            {
                _context.Tasks.Remove(result);
                _context.SaveChanges(true);
            }
        }

        public TaskModel Get(int taskId)
        {
          return _context.Tasks.SingleOrDefault(e=>e.IdTask == taskId);
        }

        public IQueryable<TaskModel> GetActive()
        {
            return _context.Tasks.Where(x => !x.IsDone);
        }

        public void Update(int taskId, TaskModel taskModel)
        {
           var result = _context.Tasks.SingleOrDefault(e=>e.IdTask==taskId);
            if (result != null)
            {
                result.Name = taskModel.Name;
                result.Description = taskModel.Description;
                result.IsDone = taskModel.IsDone;

                _context.SaveChanges();
            }
        }
    }
}
