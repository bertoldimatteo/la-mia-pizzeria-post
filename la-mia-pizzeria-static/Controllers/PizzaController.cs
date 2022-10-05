using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace la_mia_pizzeria_post.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzaList = new List<Pizza>();

            pizzaList.Add(new Pizza("Pizza Margherita", "Pizza Margherita Classica", "https://images.fidhouse.com/fidelitynews/wp-content/uploads/sites/6/2014/10/Pizza-margherita-57102-2.jpg?w=580", 10));
            pizzaList.Add(new Pizza("Pizza Diavola", "Pizza con salamino piccante", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhv3MC1OpOfcPvWOlp1LtQUef4QdwS7l_6Cg&usqp=CAU", 12));
            pizzaList.Add(new Pizza("Pizza Radicchio e Salsiccia", "Pizza con radicchi Trevigiano e Salsiccia nostrana", "https://www.lospicchiodaglio.it/img/ricette/pizzaradicchio.jpg", 15));
            pizzaList.Add(new Pizza("Pizza Patatosa", "Pizza con patate fritte", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQn0ZMfnk4NU2aK-hSyLJQcsxxYLhZ7E6AwSQ&usqp=CAU", 15));

            return View(pizzaList);
        }

        public IActionResult Detail(int id)
        {
            List<Pizza> pizzaList = new List<Pizza>();

            pizzaList.Add(new Pizza("Pizza Margherita", "Pizza Margherita Classica", "https://images.fidhouse.com/fidelitynews/wp-content/uploads/sites/6/2014/10/Pizza-margherita-57102-2.jpg?w=580", 10));
            pizzaList.Add(new Pizza("Pizza Diavola", "Pizza con salamino piccante", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhv3MC1OpOfcPvWOlp1LtQUef4QdwS7l_6Cg&usqp=CAU", 12));
            pizzaList.Add(new Pizza("Pizza Radicchio e Salsiccia", "Pizza con radicchi Trevigiano e Salsiccia nostrana", "https://www.lospicchiodaglio.it/img/ricette/pizzaradicchio.jpg", 15));
            pizzaList.Add(new Pizza("Pizza Patatosa", "Pizza con patate fritte", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQn0ZMfnk4NU2aK-hSyLJQcsxxYLhZ7E6AwSQ&usqp=CAU", 15));

            return View(pizzaList[id]);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (Pizza formData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", formData);
            }

            using (PizzaContext context = new PizzaContext())
            {
                Pizza pizza = new Pizza();
                pizza.Name = formData.Name;
                pizza.Description = formData.Description;
                pizza.Photo = formData.Photo;
                pizza.Price = formData.Price;

                context.Pizzas.Add(pizza);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }

}
