using DJValetingService.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DJValetingService.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }
        public DbSet<Ref_Flexibility> Ref_Flexibilities { get; set; }
        public DbSet<Ref_VehicleSize> Ref_VehicleSizes { get; set; }
        public DbSet<ValetingRequest> ValetingRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "8b1f1931-99b6-4efd-9127-fd6fc1274968", // primary key
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    //password is Pa55word!
                    PasswordHash = "AQAAAAEAACcQAAAAEGuPgcQAgn4yPWtCk0iaeq5hlcG+iRyKH9A7ZANBl/QVK32k+z9VTxz3zd8OLelvtw==",
                    Email = "admin@test.com",
                    EmailConfirmed = true,
                    ConcurrencyStamp = "0b1ebfe1-15ca-4b86-b1af-b8709241d7cb",
                    SecurityStamp = "57ff1a07-dc8d-4ea2-9d07-e572f9b98b78"
                }
            );
            modelBuilder.Entity<Ref_Flexibility>().HasData(
                new Ref_Flexibility() {Id=1, Flexibility = "+/- 1 Day"},
                new Ref_Flexibility() {Id=2, Flexibility = "+/- 2 Day" },
                new Ref_Flexibility() {Id=3, Flexibility = "+/- 3 Day" }
                );
            modelBuilder.Entity<Ref_VehicleSize>().HasData(
                new Ref_VehicleSize() { Id = 1, Size = "Small" },
                new Ref_VehicleSize() { Id = 2, Size = "Medium" },
                new Ref_VehicleSize() { Id = 3, Size = "Large" },
                new Ref_VehicleSize() { Id = 4, Size = "Van" }
                );
        }
    }
}