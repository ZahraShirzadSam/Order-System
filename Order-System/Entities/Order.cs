using Order_System.Enums;

namespace Order_System.Entities
{
    public class Order
    {
        private readonly DateTime _createDate;
        public OrderStatus OrderStatus { get; set; }
        public Payment payment { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public Customer customer { get; set; }

    }
}
