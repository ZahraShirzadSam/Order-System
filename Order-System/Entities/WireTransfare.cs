namespace Order_System.Entities
{
    public class WireTransfare : Payment
    {
        private readonly string _bankID;
        private readonly string _bankName;

        public WireTransfare(float amount, string bankID, string bankName) : base(amount)
        {
            _bankID = bankID;
            _bankName = bankName;
        }
    }
}
