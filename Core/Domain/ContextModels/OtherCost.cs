using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Domain.ContextModels
{
  public class OtherCost : BaseModel
  {
    public string Description { get; set; }
    public int Cost { get; set; }
    public DateTime PaymentDate { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    public Company Company { get; set; }
  }
}