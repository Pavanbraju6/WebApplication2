namespace WebApplication2.Model
{
    public class Pizza
    {
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
        public decimal Price { get; set; }
    }

    public class Pizzeria
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Pizza> Menu { get; set; }
    }
}
