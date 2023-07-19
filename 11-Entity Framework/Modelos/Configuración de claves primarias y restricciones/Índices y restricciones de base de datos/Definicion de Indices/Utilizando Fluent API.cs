using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasIndex(c => c.Name)
            .IsUnique()
            .HasName("IX_CustomerName");
    }
}

/*En este ejemplo, hemos utilizado Fluent API en el método OnModelCreating del contexto de la base de datos para definir un índice en la propiedad Name de la entidad Customer. Hemos utilizado los métodos HasIndex, IsUnique y HasName para configurar el índice.*/