
using la_mia_pizzeria_post.Other.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_post.Models
{
    [Table("pizza")]
    public class Pizza
    {
        public int PizzaID { get; set; }
        [StringLength(50, ErrorMessage = "Il nome non può avere più di 50 caratteri")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [MoreThanFiveWordValidation]
        public string Description { get; set; }
        public string Photo { get; set; }

        [Range(1, 999, ErrorMessage = "Il prezzo non può essere inferiore a 1")]
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
