using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ContextModels
{
  public class Installment : BaseModel
  {
    public string Title { get; set; }
    public string PaymentDate { get; set; }
    public string PaymentValue { get; set; }
    public string IsPaid { get; set; }

    public int ContractId { get; set; }
    [ForeignKey(nameof(ContractId))]
    public Contract Contract { get; set; }
  }
}