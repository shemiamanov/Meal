using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Meal.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string FoodImage { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Categoriy Category { get; set; }
    }
}
