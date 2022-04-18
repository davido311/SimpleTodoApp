using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskListApp.Models;
using TaskListApp.Services;

namespace TaskListApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        

        // GET: TaskController
        public ActionResult Index()
        {
            return View(_taskService.GetActive());
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View(_taskService.Get(id));
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel task)
        {
            _taskService.Add(task);
            return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_taskService.Get(id));
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TaskModel taskModel)
        {
          _taskService.Update(id, taskModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_taskService.Get(id));
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TaskModel taskModel)
        {
            _taskService.Delete(id);
         
            return RedirectToAction(nameof(Index));
        }



        //GET: Task/Done/5
        public ActionResult Done(int id)
        {
            TaskModel task = _taskService.Get(id);
            task.IsDone = true;
            _taskService.Update(id,task);
            return RedirectToAction(nameof(Index));

        }
    }
}
