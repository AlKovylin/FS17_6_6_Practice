namespace FS17_6_6_Practice
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterestAccount(ICalculate account)
        {
            account.CalculateInterest();
        }
    }
}
