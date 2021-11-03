using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnlineStore.Models
{
    public class PizzaModel
    {
       
       public PizzaModel(int pizzaId,string pizzaName,float price,string details,string ImageUrl,string Category)
        {
            this.pizzaId = pizzaId;
            this.pizzaName = pizzaName;
            this.price = price;
            this.details = details;
            this.ImageUrl = ImageUrl;
            this.Category=Category;
          

        }
        public int pizzaId { get; set; }
        
        [Display(Name = "Pizza Name")]
        public string pizzaName { get; set; }
        [Display(Name = "Price")]
        public float price { get; set; }

       
        [Display(Name = "Details")]
        public string details { get; set; }
      
        [Display(Name = "Url")]
        public string ImageUrl { get; set; }

        public string Category { get; set; }

     
    }
}
