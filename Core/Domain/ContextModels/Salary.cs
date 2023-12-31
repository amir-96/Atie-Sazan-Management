using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ContextModels
{
  public class Salary : BaseModel
  {
    public string Employee { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
    public DateTime PaymentDate { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    public Company Company { get; set; }
  }
}