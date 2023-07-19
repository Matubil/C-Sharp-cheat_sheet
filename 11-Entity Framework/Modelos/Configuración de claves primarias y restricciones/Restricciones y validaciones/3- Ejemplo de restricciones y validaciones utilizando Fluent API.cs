public class ApplicationDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .Property(c => c.Name)
            .IsRequired(); // Fluent API para indicar que la propiedad es obligatoria

        modelBuilder.Entity<Customer>()
            .Property(c => c.Name)
            .HasMaxLength(50); // Fluent API para limitar la longitud de la cadena

        modelBuilder.Entity<Customer>()
            .Property(c => c.Age)
            .IsRequired()
            .HasDefaultValue(18); // Fluent API para indicar que la propiedad es obligatoria y establecer un valor predeterminado
    }
}

/*En este ejemplo, hemos utilizado Fluent API para configurar restricciones y validaciones en las propiedades Name y Age de la entidad Customer. Hemos utilizado los métodos IsRequired(), HasMaxLength() y HasDefaultValue() para aplicar las restricciones correspondientes.*/