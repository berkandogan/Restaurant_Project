using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderFood> OrderFoods { get; set; }
        public Payment Payment { get; set; }
    }
}
