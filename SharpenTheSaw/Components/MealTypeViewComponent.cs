using Microsoft.AspNetCore.Mvc;
using SharpenTheSaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpenTheSaw.Components
{
    public class MealTypeViewComponent : ViewComponent
    {
        private RecipesContext context;

        public MealTypeViewComponent(RecipesContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            return View(context.RecipeClasses
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
