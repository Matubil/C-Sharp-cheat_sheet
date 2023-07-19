public class ApplicationDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasKey(c => c.CustomerId); // Fluent API para configurar la clave primaria
    }
}

/*En este ejemplo, hemos utilizado Fluent API en el método OnModelCreating del contexto de la base de datos para configurar la clave primaria de la entidad Customer utilizando el método HasKey.*/