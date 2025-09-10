using Microsoft.EntityFrameworkCore;

namespace MIDTERM_LAB3_DANIEL_RED.Models;

public partial class StudentDbContext : DbContext
{
    // This constructor allows dependency injection to pass in the configured options.
    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // We leave this mostly empty to let EF Core use its default conventions,
        // which will respect the auto-incrementing primary key from the database.
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}