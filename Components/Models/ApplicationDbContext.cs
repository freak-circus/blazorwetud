   // Models/ApplicationDbContext.cs
   using Microsoft.EntityFrameworkCore;
   namespace blazorwetud.Components;

   public class ApplicationDbContext : DbContext
   {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

       public DbSet<User> Users { get; set; }
       public DbSet<Task> Tasks { get; set; }
       public DbSet<Article> Articles { get; set; }
       public DbSet<QuizTask> QuizTasks { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);
           // Дополнительная конфигурация моделей при необходимости
       }
   }