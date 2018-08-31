using System;
using AppPeople.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPeople.Controllers
{
    public class PeopleController : Controller
    {

        private readonly IPersonRepository _repository;

        public PeopleController(IPersonRepository peopleRepository) {
            _repository = peopleRepository;
        }
        
        public IActionResult Index() {

            var people = _repository.GetAll();

            return View(people);
        }

        [HttpGet]
        public IActionResult Create() {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person) {

            _repository.Create(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id) {

            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Person person) {
            _repository.Update(person);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}