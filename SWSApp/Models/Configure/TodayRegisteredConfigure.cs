using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SWSApp.Models.Entities;

namespace SWSApp.Models.Configure;

public class TodayRegisteredConfigure : IEntityTypeConfiguration<TodayRegistered>
{
    public void Configure(EntityTypeBuilder<TodayRegistered> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
        
    }
}