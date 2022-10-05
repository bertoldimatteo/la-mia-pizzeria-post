
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_post.Models
{
    [Table("pizza")]
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }

        public Pizza()
        {

        }
        public Pizza(string name, string description,string photo, int price)
        {
            Name = name;
            Description = description;
            Photo = photo;
            Price = price;
        }
    }
}
