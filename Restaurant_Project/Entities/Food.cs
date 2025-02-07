using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Entities
{
    internal class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<MenuFood> MenuFoods { get; set; }
        public List<OrderFood> OrderFoods { get; set; }
    }
}
