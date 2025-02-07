using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Entities
{
    internal class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MenuFood> MenuFoods { get; set; }
    }
}
