using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ContextModels
{
  public class TaskMaster : BaseModel
  {
    public string Pelak { get; set; }
    public string Name { get; set; }
    public string IsActive { get; set; }

    public int CompanyId { get; set; }
    [ForeignKey(nameof(CompanyId))]
    public Company Company { get; set; }

    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
  }
}