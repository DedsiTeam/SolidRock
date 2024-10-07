using Microsoft.EntityFrameworkCore;
using SolidRockIdentity.Roles;
using SolidRockIdentity.Users;
using Volo.Abp;

namespace SolidRockIdentity.EntityFrameworkCore;

public static class SolidRockIdentityDbContextModelCreatingExtensions
{
    public static void ConfigureProjectName(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<User>(b =>
        {
            b.ToTable("Users", SolidRockIdentityDomainOptions.DbSchemaName);
            b.HasKey(a => a.Id);
        });

        builder.Entity<Role>(b =>
        {
            b.ToTable("Roles", SolidRockIdentityDomainOptions.DbSchemaName);
            b.HasKey(a => a.Id);
        });

        builder.Entity<UserRole>(b =>
        {
            b.ToTable("UserRoles", SolidRockIdentityDomainOptions.DbSchemaName);
            b.HasKey(a => a.Id);
        });

    }
}