namespace Domain.ContextModels
{
    public class Contract : BaseModel
    {
        public string Pelak { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalPayment { get; set; }
        public ITEnum InstallmentType { get; set; }
        public int InstallmentCount { get; set; }
        public string ContrctStartTime { get; set; }
        public string ContractEndTime { get; set; }
        public string IsActive { get; set; }
    }
}