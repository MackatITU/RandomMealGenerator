using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RandomMealGenerator.Models
{
    public class ProductModel
    {
 
        public class Rootobject
        {
            public Meal[] meals { get; set; }
        }

        public class Meal
        {
            public string strMeal { get; set; }
            public string strCategory { get; set; }
            public string strArea { get; set; }
            public string strInstructions { get; set; }
            public string strMealThumb { get; set; }
            public string strIngredient1 { get; set; }
            public string strIngredient2 { get; set; }
            public string strIngredient3 { get; set; }
            public string strIngredient4 { get; set; }
            public string strIngredient5 { get; set; }
            public string strIngredient6 { get; set; }
            public string strIngredient7 { get; set; }
            public string strIngredient8 { get; set; }
            public string strIngredient9 { get; set; }
            public string strIngredient10 { get; set; }
            public string strIngredient11 { get; set; }
            public string strIngredient12 { get; set; }
            public string strIngredient13 { get; set; }
            public string strIngredient14 { get; set; }
            public string strIngredient15 { get; set; }
            public string strIngredient16 { get; set; }
            public string strIngredient17 { get; set; }
            public string strIngredient18 { get; set; }
            public string strIngredient19 { get; set; }
            public string strIngredient20 { get; set; }

        }

    }
}
