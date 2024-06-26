using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System.Entities
{
    public class Item
    {
        private readonly float _weight;
        private readonly string _description;
        public OrderDetail? orderDetail { get; set; }

        public Item(float weight, string description)
        {
            _weight = weight;
            _description = description;
        }
        public void GetPriceForquantity()
        { }
        public void GetWeight()
        { }
    }
}
