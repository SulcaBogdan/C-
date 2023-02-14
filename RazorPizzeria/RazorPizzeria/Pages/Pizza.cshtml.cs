using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
			new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=3, TomatoSauce=true, Cheese=true,Beef=true, FinalPrice=5},
			new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=3, TomatoSauce=false, Cheese=true,Mushroom=true, FinalPrice=4},
			new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=10, TomatoSauce=true, Cheese=true,Pineapple=true, Ham=true, FinalPrice=14},
			new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=3, TomatoSauce=true, Cheese=true, Beef=true, Ham=true, Peperoni=true, FinalPrice=7},
			new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true,Mushroom=true, FinalPrice=5},
			new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true,Peperoni=true, FinalPrice=4},
			new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=5, TomatoSauce=true, Cheese=true,Tuna=true, FinalPrice=8},
			new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=2, TomatoSauce=true, Cheese=true,Mushroom=true, FinalPrice=4}


		};
        public void OnGet()
        {
        }
    }
}
