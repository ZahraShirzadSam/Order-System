

namespace Order_System.Entities
{
    public class Item
    {
        private readonly float _weight;
        private readonly string _description;
        public OrderDetail? orderDetail { get; set; }

        public void GetPriceForquantity()
        { }
        public void GetWeight()
        { }
    }
}
