namespace Order_System.Entities
{
    public class OrderDetail
    {
        private readonly int _qty;
        private readonly string _taxStatus;
        public Order order { get; set; }
        public ICollection<Item> items { get; set; }

        public void CalculateSubTotal()
        { }
        public void CalculateWaight()
        { }
    }
}
