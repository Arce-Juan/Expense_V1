namespace Core.Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public ExpenseType Type { get; set; }
        public PeriodMonth Month { get; set; }
    }
}
