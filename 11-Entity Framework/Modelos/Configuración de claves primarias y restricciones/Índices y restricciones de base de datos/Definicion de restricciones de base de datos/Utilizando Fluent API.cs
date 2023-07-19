using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}

/*En este ejemplo, hemos utilizado Fluent API en el método OnModelCreating del contexto de la base de datos para definir restricciones en la propiedad Name de la entidad Customer. Hemos utilizado los métodos IsRequired y HasMaxLength para configurar las restricciones.*/