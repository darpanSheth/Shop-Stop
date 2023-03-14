using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using Module1AssignmentAngular.Models;

namespace Module1AssignmentAngular.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    

    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
        
    }

    public DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>().HasData
            (
                new Product { ProductId = 1, Filename = "assets/Images/Tshirt.png", Name = "Custom Tshirts", Price = 25.80M, Description = "Get a pure Cotton material White Tshirt with front and back side design of your choice." },
                new Product { ProductId = 2, Filename = "assets/Images/IphoneCase.png", Name = "Custom Iphone 14 Pro Case", Price = 36.50M, Description = "Get a black case for Iphone 14 Pro max with best magnet quality and the design of your choice" },
                new Product { ProductId = 3, Filename = "assets/Images/Jeans.png", Name = "Custom Jeans", Price = 44, Description = "Get a Pure Denim Jeans in all sizes with a design of your choice" },
                new Product { ProductId = 4, Filename = "assets/Images/Earpiece.jpg", Name = "Wireless Earpiece", Price = 60, Description = "Get a wireless Earpiece with very good sound quality" }

            ); ;
    }
}

