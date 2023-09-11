using Microsoft.EntityFrameworkCore;
public class Contexto: DbContext
{
 public DbSet<clientes> clientes{get; set;}


 public Contexto(DbContextOptions<Contexto>options): base(options){ }

}