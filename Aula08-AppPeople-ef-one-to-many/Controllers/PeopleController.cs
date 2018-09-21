

using AppPeople.Models;
using Aula04_AppPeople_ef.Models;
using Aula05_AppPeople_ef_one_to_many.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPeople.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPersonRepository _repository;

        public PeopleController(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var people = _repository.GetAll();          

            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.city = new City{ id=2 };

            _repository.Create(person);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _repository.Update(person);
            return RedirectToAction("Index");
        }
    
    }
}
