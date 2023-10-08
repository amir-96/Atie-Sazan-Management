using Domain.ContextModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
  public class ApplicationDbContext : IdentityDbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<TaskMaster> TaskMasters { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Installment> Installments { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<AdministrativeCost> AdministrativeCosts { get; set; }
    public DbSet<OtherCost> OtherCosts { get; set; }
  }
}
