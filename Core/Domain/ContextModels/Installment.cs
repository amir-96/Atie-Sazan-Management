namespace Domain.ContextModels
{
    public class Installment : BaseModel
    {
        public string Title { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentValue { get; set; }
        public string IsPaid { get; set; }
    }
}