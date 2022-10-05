using la_mia_pizzeria_post.Models;

namespace la_mia_pizzeria_post.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }

        public Pizza(string name, string description,string photo, int price)
        {
            Name = name;
            Description = description;
            Photo = photo;
            Price = price;
        }
    }
}
