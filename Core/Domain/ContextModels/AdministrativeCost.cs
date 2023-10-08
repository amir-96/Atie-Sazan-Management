using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ContextModels
{
  public class AdministrativeCost : BaseModel
  {
    public string Description { get; set; }
    public int Cost { get; set; }
    public DateTime PaymentDate { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    public Company Company { get; set; }
  }
}