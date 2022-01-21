namespace FS17_6_6_Practice
{
    public abstract class Account : ICalculate
    {
        /// <summary>
        /// Баланс учетной записи.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// Процентная ставка.
        /// </summary>
        public double Interest { get; set; } = 0;

        public Account(double balance)
        {
            Balance = balance;
        }

        public abstract void CalculateInterest();
    }
}
