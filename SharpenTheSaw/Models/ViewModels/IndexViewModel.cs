using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpenTheSaw.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Recipes> Recipes { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
        public string MealCategory { get; set; }
    }
}
