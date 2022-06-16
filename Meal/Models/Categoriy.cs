using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meal.Models
{
    public class Categoriy
    {
        public int Id { get; set; }
        public string CategoriyName { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
