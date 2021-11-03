using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnlineStore.Models
{
    public class PizzaBO
    {
        public List<PizzaModel> pizzas = new List<PizzaModel>();
        public PizzaBO()
        {
            pizzas.Add(new PizzaModel(pizzaId: 1, pizzaName: "Double Cheese Margherita", price: 200, details: "A classic delight loaded with extra 100% real mozzarella cheese", ImageUrl: "/images/pizza4.jpg", Category: "Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 2, pizzaName: "The Cheese Dominator", price: 275, details: "Cheese Overloaded pizza with 4 different varieties of cheese and 4 times the cheese of a normal pizza, including a spicy hit of Ghost Pepper flavoured Cheese", ImageUrl: "/images/pizza2.jpg", Category: "Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 3, pizzaName: "Mexican Green Wave", price: 300, details: "Mexican herbs sprinkled on onion, capsicum, tomato & jalapeno", ImageUrl: "/images/pizza3.jpg", Category: "Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 4, pizzaName: "Farmhouse", price: 275, details: "Delightful combination of onion, capsicum, tomato & grilled mushroom", ImageUrl: "/images/pizza.jpg", Category: "Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 5, pizzaName: "The Unthinkable Pizza", price: 250, details: "Loaded with Plant Based Protein topping along with Black Olives & Red Paprika enjoy this unique 100% Vegetarian pizza with a 100% Chicken like taste!", ImageUrl: "/images/pizza5.jpg", Category: "Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 6, pizzaName: "Creamy Tomato Pasta Pizza - Non Veg", price: 300, details: "Loaded with a delicious creamy tomato pasta topping, BBQ pepper chicken, green capsicum, crunchy red and yellow bell peppers.", ImageUrl: "/images/pizza6.jpg", Category: "Non-Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 7, pizzaName: "Moroccan Spice Pasta Pizza - Non Veg", price: 300, details: "A pizza loaded with a spicy combination of Harissa sauce, Peri Peri chicken chunks and delicious pasta.", ImageUrl: "/images/pizza10.jpg", Category: "Non-Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 8, pizzaName: "Chicken Golden Delight", price: 350, details: "Double pepper barbecue chicken, golden corn and extra cheese, true delight", ImageUrl: "/images/pizza8.jpg", Category: "Non-Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 9, pizzaName: "Non Veg Supreme", price: 370, details: "Supreme combination of black olives, onion, capsicum, grilled mushroom, pepper barbecue chicken, peri-peri chicken & grilled chicken rashers", ImageUrl: "/images/pizza9.jpg", Category: "Non-Vegetarian"));
            pizzas.Add(new PizzaModel(pizzaId: 10, pizzaName: "Chicken Pepperoni", price: 350, details: "A classic American taste! Relish the delectable flavor of Chicken Pepperoni, topped with extra cheese", ImageUrl: "/images/pizza7.jpg", Category: "Non-Vegetarian"));
        }
        public List<PizzaModel> GetPizzas()
        {
            return pizzas;
        }
        public PizzaModel GetPizzabyId(int id)
        {
            return pizzas.Find(x => x.pizzaId == id);
        }
        public List<String> GetPizzaCategories()
        {
            List<String> CategoryList = new List<string>{ "Vegetarian", "Non-Vegetarian" };
            return CategoryList;
        }
    }
}
