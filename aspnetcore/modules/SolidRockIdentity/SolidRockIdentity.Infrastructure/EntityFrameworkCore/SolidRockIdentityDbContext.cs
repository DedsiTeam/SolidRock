using Dedsi.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolidRockIdentity.Roles;
using SolidRockIdentity.Users;
using Volo.Abp.Data;

namespace SolidRockIdentity.EntityFrameworkCore;

[ConnectionStringName(SolidRockIdentityDomainOptions.ConnectionStringName)]
public class SolidRockIdentityDbContext(DbContextOptions<SolidRockIdentityDbContext> options) 
    : DedsiEfCoreDbContext<SolidRockIdentityDbContext>(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigureProjectName();
    }

}