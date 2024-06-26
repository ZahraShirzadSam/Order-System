namespace Order_System.Entities
{
    public class Check : Payment
    {
        private readonly string _name;
        private readonly string _bankID;

        public Check(float amount, string name, string bankID) : base(amount)
        {
            _name = name;
            _bankID = bankID;
        }

    }
}
