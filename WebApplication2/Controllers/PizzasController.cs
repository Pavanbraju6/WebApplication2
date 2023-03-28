using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Model;

namespace PizzaOrdering.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : ControllerBase
    {
        private static readonly List<Pizzeria> Pizzerias = new List<Pizzeria>
        {
            new Pizzeria
            {
                Name = "Preston Pizzeria",
                Location = "Preston",
                Menu = new List<Pizza>
                {
                    new Pizza { Name = "Capricciosa", Ingredients = new[] { "Cheese", "Ham", "Mushrooms", "Olives" }, Price = 20 },
                    new Pizza { Name = "Mexicana", Ingredients = new[] { "Cheese", "Salami", "Capsicum", "Chilli" }, Price = 18 },
                    new Pizza { Name = "Margherita", Ingredients = new[] { "Cheese", "Spinach", "Ricotta", "Cherry Tomatoes" }, Price = 22 }
                }
            },
            new Pizzeria
            {
                Name = "Southbank Pizzeria",
                Location = "Southbank",
                Menu = new List<Pizza>
                {
                    new Pizza { Name = "Capricciosa", Ingredients = new[] { "Cheese", "Ham", "Mushrooms", "Olives" }, Price = 25 },
                    new Pizza { Name = "Vegetarian", Ingredients = new[] { "Cheese", "Mushrooms", "Capsicum", "Onion", "Olives" }, Price = 17 }
                }
            }
        };

        private readonly ILogger<PizzasController> _logger;

        public PizzasController(ILogger<PizzasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Pizzeria>> Get()
        {
            return Pizzerias;
        }
    }
}
