using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ContextModels
{
  public class Engineer : BaseModel
  {
    public string Name { get; set; }
    public ETEnum Type { get; set; }
    public bool IsActive { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    public Company Company { get; set; }

    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
  }
}