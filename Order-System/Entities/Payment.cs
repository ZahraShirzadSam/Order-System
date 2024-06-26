namespace Order_System.Entities
{
    public class Payment
    {
        private readonly float _amount;
        public ICollection<Order> orders { get; set; }
        public Payment(float amount)
        {
            _amount = amount;
        }
    }
}
