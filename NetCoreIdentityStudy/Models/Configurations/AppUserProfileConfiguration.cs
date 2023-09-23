using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentityStudy.Models.Entities;

namespace NetCoreIdentityStudy.Models.Configurations
{
    public class AppUserProfileConfiguration:BaseConfiguration<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);

        }
    }
}
