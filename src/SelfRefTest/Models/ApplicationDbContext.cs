using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace SelfRefTest.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Term>  Terms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Term>()
                .HasKey(t => new { t.Id, t.CategoryId });

            builder.Entity<Term>()
                .HasOne(x => x.Parent)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentId)
                .HasPrincipalKey(x => x.Id)
                .IsRequired(false);
        }
    }
}