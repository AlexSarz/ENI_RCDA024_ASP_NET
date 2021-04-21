using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;

namespace TP04.Utils
{
    public class FakeDb
    {
        private static readonly Lazy<FakeDb> lazy = new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {
            this.InitialiserIngredients();
            this.InitialiserPates();
            this.InitialiserPizzas();
        }

        public List<Pizza> Pizzas { get; } = new List<Pizza>();
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
        public List<Pate> Pates { get; } = new List<Pate>();          
        private void InitialiserIngredients()
        {            
            Ingredients.Add(new Ingredient { Id = 1, Nom = "Mozzarella" });
            Ingredients.Add(new Ingredient { Id = 2, Nom = "Jambon" });
            Ingredients.Add(new Ingredient { Id = 3, Nom = "Tomate" });
            Ingredients.Add(new Ingredient { Id = 4, Nom = "Oignon" });
            Ingredients.Add(new Ingredient { Id = 5, Nom = "Cheddar" });
            Ingredients.Add(new Ingredient { Id = 6, Nom = "Saumon" });
            Ingredients.Add(new Ingredient { Id = 7, Nom = "Champignon" });
            Ingredients.Add(new Ingredient { Id = 8, Nom = "Poulet" });            
        }
        private void InitialiserPates()
        {            
            Pates.Add(new Pate { Id = 1, Nom = "Pate fine, base crême" });
            Pates.Add(new Pate { Id = 2, Nom = "pate fine, base tomate" });
            Pates.Add(new Pate { Id = 3, Nom = "pate épaisse, base crême" });
            Pates.Add(new Pate { Id = 4, Nom = "pate épaisse, base tomate" });            
        }
        private void InitialiserPizzas()
        {              
            Pizzas.Add(new Pizza { 
                Id = 1, 
                Nom = "Margarita", 
                Pate = Pates.ElementAt(1), 
                Ingredients = new List<Ingredient> { Ingredients.ElementAt(0), Ingredients.ElementAt(1) 
            } });
            Pizzas.Add(new Pizza { 
                Id = 2, 
                Nom = "4 fromages", 
                Pate = Pates.ElementAt(3), 
                Ingredients = new List<Ingredient> { Ingredients.ElementAt(0), Ingredients.ElementAt(4) 
            } });
            Pizzas.Add(new Pizza { 
                Id = 3, 
                Nom = "Forestière", 
                Pate = Pates.ElementAt(2), 
                Ingredients = new List<Ingredient> { Ingredients.ElementAt(0), Ingredients.ElementAt(6), Ingredients.ElementAt(7) 
            } });
            Pizzas.Add(new Pizza { 
                Id = 4, 
                Nom = "Norvégienne", 
                Pate = Pates.ElementAt(0), 
                Ingredients = new List<Ingredient> { Ingredients.ElementAt(0), Ingredients.ElementAt(5) 
            } });
            Pizzas.Add(new Pizza { 
                Id = 5, 
                Nom = "Montagnarde", 
                Pate = Pates.ElementAt(1), 
                Ingredients = new List<Ingredient> { Ingredients.ElementAt(0), Ingredients.ElementAt(2), Ingredients.ElementAt(3), Ingredients.ElementAt(6) 
            } });
        }
    }
}