using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class OptionConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            //builder.HasOne(x => x.Question)
            //    .WithMany()
            //    .HasForeignKey(x => x.QuestionId)
            //    .OnDelete(DeleteBehavior.NoAction);

        }     
    }
}
