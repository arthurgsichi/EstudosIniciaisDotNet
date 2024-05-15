using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Contexts;

public class AppDbContex : DbContext
{
    public DbSet<Cliente> Clientes => Set<Cliente>();
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=.;Database=DbArthur;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
    }
}