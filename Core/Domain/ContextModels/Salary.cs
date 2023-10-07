namespace Domain.ContextModels
{
    public class Salary : BaseModel
    {
        public string Employee { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}