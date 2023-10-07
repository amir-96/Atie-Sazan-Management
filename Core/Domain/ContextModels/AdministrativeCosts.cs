namespace Domain.ContextModels
{
    public class AdministrativeCosts : BaseModel
    {
        public string Description { get; set; }
        public int Cost { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}