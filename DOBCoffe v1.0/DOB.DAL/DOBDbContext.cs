using DOB.Entity.Entitys;
using DOB.EntityTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DAL
{
    public class DOBDbContext:DbContext
    {
        public DOBDbContext() : base("data source=213.14.169.11;database=DOBCoffee;User Id=bak402; Password=Alaf9090;")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DOBDbContext>());
        }
       
        //protected override void Seed(DOBDbContext context)
        //{
        //    IList<Product> products = new List<Product>();

        //    products.Add(new Product() { ProductName = "Standard 1", Description = "First Standard" });
        //    products.Add(new Product() { ProductName = "Standard 2", Description = "Second Standard" });
        //    products.Add(new Product() { ProductName = "Standard 3", Description = "Third Standard" });

        //    context.Products.AddRange(products);

        //    base.Seed(context);
        //}

        public virtual DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());


            base.OnModelCreating(modelBuilder);
        }

       

    }
}
