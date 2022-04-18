using System.Linq;
using TaskListApp.Models;

namespace TaskListApp.Services
{
    public interface ITaskService
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetActive();
        void Add(TaskModel taskModel);
        void Update(int taskId,TaskModel taskModel);
        void Delete(int taskId);
    }
}
