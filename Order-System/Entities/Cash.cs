namespace Order_System.Entities
{
    public class Cash : Payment
    {
        private readonly float _cashTendered;

        public Cash(float amount, float cashTendered) : base(amount)
        {
            _cashTendered = cashTendered;
        }
    }
}
