using Task_Manager.Models;
using Task_Manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace Task_Manager.Controllers
{
    public class TaskController : Controller
    {
        //Inicijalizacija servisa
        private readonly TaskService _service;

        //Inicijalizacija kontrolera sa parametrom (konstruktor)
        public TaskController(TaskService service)
        {
            _service = service;
        }

        //READ
        public IActionResult Index()
        {
            var tasks = _service.GetAll();
            return View(tasks);
        }

        // CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //Metoda se poziva kada forma posalje podatke metodom POST
        public IActionResult Create(Models.Task task)
        {
            if (ModelState.IsValid) //Proveravanje validacije podataka u Modelu
            {
                _service.Add(task);
                return RedirectToAction(nameof(Index)); //Prebacivanje na Index akciju
            }
            return View(task);
        }

        // UPDATE
        public IActionResult Edit(int id)
        {
            var task = _service.GetById(id);
            if (task == null) return NotFound();
            return View(task);
        }

        // UPDATE
        [HttpPost]
        public IActionResult Edit(Models.Task task)
        {
            if (ModelState.IsValid)
            {
                _service.Update(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var task = _service.GetById(id);
            if (task == null) return NotFound();
            return View(task);
        }

        // DELETE
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }/////////////////////////
}
