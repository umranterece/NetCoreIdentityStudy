using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentityStudy.Models.Entities;

namespace NetCoreIdentityStudy.Models.Configurations
{
    public class AppUserRoleConfiguration:BaseConfiguration<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            //builder.ToTable("Kullanicilar");
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.UserId,
                x.RoleId
            });
        }
    }
}
