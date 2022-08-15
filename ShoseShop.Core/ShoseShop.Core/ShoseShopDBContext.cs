using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using ShoseShop.Core.BaseEntities;
using ShoseShop.Core.Entity;
using System;

namespace ShoseShop.Core
{
    public class ShoseShopDBContext : DbContext
    {
        public ShoseShopDBContext()
        {
        }
        /*public ShoseShopDBContext(DbContextOptions<ShoseShopDBContext> options) : base(options)
        {
        }*/

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ImageProduct> ImageProducts { get; set; }


        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Server=.;Database=ShoseOnline;Trusted_Connection=True; MultipleActiveResultSets = true";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blog>(tp =>
            {
                tp.HasKey(c => c.BlogID);
                tp.HasOne(p => p.BlogCategory)
                        .WithMany(c => c.Blogs)
                        .HasForeignKey(p => p.BlogCategoryID);
                tp.Property(c => c.BlogName)
                        .HasColumnType("nvarchar(50)")
                        .IsRequired();
                tp.Property(c => c.Images)
                        .HasColumnType("nvarchar(300)")
                        .IsRequired();
                tp.Property(c => c.Content)
                        .HasColumnType("ntext")
                        .IsRequired();

            });


            modelBuilder.Entity<BlogCategory>(sp =>
            {

                sp.HasKey(c => c.BlogCategoryID);

                sp.Property(c => c.BlogCategoryName)
                        .HasColumnType("nvarchar(50)")
                        .IsRequired();

            });



            modelBuilder.Entity<Category>(sp =>
            {

                sp.HasKey(c => c.CategoryID);

                sp.Property(c => c.CategoryName)
                        .HasColumnType("nvarchar(200)")
                        .IsRequired();


            });

            modelBuilder.Entity<Contact>(sp =>
            {

                sp.HasKey(c => c.ContactID);
                sp.Property(c => c.CustomerName)
                        .HasColumnType("nvarchar(100)");
                sp.Property(c => c.Email)
                        .HasColumnType("varchar(50)")
                        .IsRequired();
                sp.Property(c => c.Phone)
                        .HasColumnType("varchar(20)")
                        .IsRequired();
                sp.Property(c => c.Content)
                        .HasColumnType("ntext")
                        .IsRequired();


            });

            modelBuilder.Entity<ImageProduct>(sp =>
            {
                sp.HasKey(c => c.ImageID);
                sp.HasOne(p => p.Product)
                        .WithMany(c => c.ImageProducts)
                        .HasForeignKey(p => p.ProductID);
                sp.HasMany(c => c.ProductDetails)
                        .WithOne(p => p.ImageProduct)
                        .HasForeignKey(p => p.ImageID);

                sp.Property(c => c.Images)
                        .HasColumnType("nvarchar(300)")
                        .IsRequired();

            });

            modelBuilder.Entity<OrderDetail>(sp =>
            {
                sp.HasKey(sp => new { sp.ImageID, sp.OrderID, sp.SizeID });
                sp.HasOne(p => p.ProductDetail)
                        .WithMany(c => c.OrderDetails)
                        .HasForeignKey(p => p.SizeID);
                sp.HasOne(p => p.Orders)
                        .WithMany(c => c.OrderDetails)
                        .HasForeignKey(p => p.OrderID);
                sp.Property(c => c.Amount)
                         .HasColumnType("int")
                         .IsRequired();

            });

            modelBuilder.Entity<Orders>(sp =>
            {
                sp.HasKey(c => c.OrderID);
                sp.HasOne(p => p.User).WithMany(c => c.Orders).HasForeignKey(p => p.UserID);
                sp.Property(c => c.UserName)
                        .HasColumnType("nvarchar(255)")
                        .IsRequired();

                sp.Property(c => c.Address)
                        .HasColumnType("nvarchar(500)")
                        .IsRequired();

                sp.Property(c => c.Phone)
                        .HasColumnType("nvarchar(12)")
                        .IsRequired();

                sp.Property(c => c.Email)
                        .HasColumnType("nvarchar(50)");

                sp.Property(c => c.Note)
                        .HasColumnType("nvarchar(500)");

            });

            modelBuilder.Entity<Product>(sp =>
            {

                sp.HasKey(c => c.ProductID);

                sp.Property(c => c.ProductName)
                        .HasColumnType("nvarchar(200)")
                        .IsRequired();
                sp.Property(c => c.Descriptions)
                        .HasColumnType("nvarchar(500)")
                        .IsRequired();
                sp.Property(c => c.Price)
                        .HasColumnType("money")
                        .IsRequired();

            });

            modelBuilder.Entity<ProductDetail>(sp =>
            {
                sp.HasKey(p => p.SizeID);
                sp.HasOne(p => p.ImageProduct)
                       .WithMany(c => c.ProductDetails)
                       .HasForeignKey(p => p.ImageID);

                sp.Property(c => c.Size)
                        .HasColumnType("int")
                        .IsRequired();

                sp.Property(c => c.AmountInput)
                        .HasColumnType("int")
                        .IsRequired();

            });

            modelBuilder.Entity<User>(sp =>
            {
                sp.HasKey(c => c.UserID);

                sp.Property(c => c.Password)
                        .HasColumnType("nvarchar(50)")
                        .IsRequired();
                sp.HasOne(p => p.Role)
                       .WithMany(c => c.Users)
                       .HasForeignKey(p => p.UserID);
                sp.Property(c => c.UserName)
                        .HasColumnType("nvarchar(100)")
                        .IsRequired();

                sp.Property(c => c.Name)
                        .HasColumnType("int")
                        .IsRequired();

                sp.Property(c => c.Address)
                        .HasColumnType("nvarchar(255)")
                        .IsRequired();

                sp.Property(c => c.Phone)
                        .HasColumnType("nvarchar(11)")
                        .IsRequired();

                sp.Property(c => c.Email)
                        .HasColumnType("nvarchar(50)")
                        .IsRequired();
            });

            modelBuilder.Entity<Role>(sp =>
            {

                sp.HasKey(p => p.RoleID);

                sp.Property(c => c.RoleName)
                        .HasColumnType("nvarchar(100)")
                        .IsRequired();

            });

            modelBuilder.Seed();
        }
        public override int SaveChanges()
        {
            BeforSaveChanges();
            return base.SaveChanges();
        }

        private void BeforSaveChanges()
        {
            var entities = this.ChangeTracker.Entries();
            foreach (var entity in entities)
            {

                if (entity.Entity is BaseEntity baseEntity)
                {
                    var now = DateTime.Now;
                    switch (entity.State)
                    {
                        case EntityState.Modified:
                            baseEntity.UpdatedDate = now;
                            break;
                        case EntityState.Added:
                            baseEntity.CreatedDate = now;
                            baseEntity.UpdatedDate = now;
                            baseEntity.IsActive = true;
                            break;
                        case EntityState.Deleted:
                            baseEntity.IsActive = false;
                            break;
                    }
                }
            }
        }

    }
}
