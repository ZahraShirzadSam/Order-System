namespace Order_System.Entities
{
    public class Check : Payment
    {
        private readonly string _name;
        private readonly string _bankID;
        public Check(float amount) : base(amount)
        {
        }
    }
}
