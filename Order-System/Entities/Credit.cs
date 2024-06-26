namespace Order_System.Entities
{
    public class Credit : Payment
    {
        private readonly string _number;
        private readonly string _type;
        private readonly DateTime _expireDate;
        public Credit(float amount) : base(amount)
        {
        }
    }
}
