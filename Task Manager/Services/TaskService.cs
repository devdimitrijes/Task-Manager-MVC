using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Task_Manager.Models;

namespace Task_Manager.Services
{
    public class TaskService
    {
        private readonly List<Models.Task> _tasks = new(); //Lista je trenutno baza podataka, jer jos ne znamo sa SQL da povezemo.
                                                           //Tzv. InMemory baza podataka
        private int _nextId = 1;

        public List<Models.Task> GetAll()
        {
            return _tasks;
        }

        public Models.Task GetById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Add(Models.Task task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
        }

        public void Update(Models.Task task)
        {
            var existing = GetById(task.Id);
            if (existing != null)
            {
                existing.Title = task.Title;
                existing.Description = task.Description;
                existing.IsDone = task.IsDone;
            }
        }

        public void Delete(int id)
        {
            var task = GetById(id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }

    }///////////////////
}

