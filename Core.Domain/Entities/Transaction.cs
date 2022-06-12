namespace Core.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Concept Concept { get; set; }
        public TransactionType TransactionType { get; set; }
        public PeriodMonth Month { get; set; }
    }
}
