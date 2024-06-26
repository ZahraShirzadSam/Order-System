namespace Order_System.Entities
{
    public class Credit : Payment
    {
        private readonly string _number;
        private readonly string _type;
        private readonly DateTime _expireDate;

        public Credit(float amount, string number, string type, DateTime expireDate) : base(amount)
        {
            _number = number;
            _type = type;
            _expireDate = expireDate;
        }
    }
}
