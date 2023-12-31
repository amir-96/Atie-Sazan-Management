using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ContextModels
{
  public class Contract : BaseModel
  {
    public string Pelak { get; set; }
    public string ContractingParty { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int TotalPayment { get; set; }
    public ITEnum InstallmentType { get; set; }
    public int InstallmentCount { get; set; }
    public string ContrctStartTime { get; set; }
    public string ContractEndTime { get; set; }
    public string IsActive { get; set; }

    public int EngineerId { get; set; }
    [ForeignKey(nameof(EngineerId))]
    public Engineer Engineer { get; set; }
    public int TaskMasterId { get; set; }
    [ForeignKey(nameof(TaskMasterId))]
    public TaskMaster TaskMaster { get; set; }

    public ICollection<Installment> Installments { get; set; } = new List<Installment>();
  }
}