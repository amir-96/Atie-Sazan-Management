namespace Domain.ContextModels
{
  public class Company : BaseModel
  {
    public string Name { get; set; }

    public ICollection<Engineer> Engineers { get; set; } = new List<Engineer>();
    public ICollection<TaskMaster> TaskMasters { get; set; } = new List<TaskMaster>();
    public ICollection<Salary> Salaries { get; set; } = new List<Salary>();
    public ICollection<AdministrativeCost> AdministrativeCosts { get; set; } = new List<AdministrativeCost>();
    public ICollection<OtherCost> OtherCost { get; set; } = new List<OtherCost>();
  }
}