namespace Order_System.Entities
{
    public class Customer
    {
        private readonly string _name;
        private readonly string _deliveryAddress;
        private readonly string _contact;
        private readonly bool _active;
        public ICollection<Order>? orders { get; set; }

    }
}
