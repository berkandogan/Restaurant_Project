using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Entities
{
    internal class MenuFood
    {
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
