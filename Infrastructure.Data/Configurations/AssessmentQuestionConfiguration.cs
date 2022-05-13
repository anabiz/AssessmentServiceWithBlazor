using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Configurations
{
    public class AssessmentQuestionConfiguration
    {
        public void Configure(EntityTypeBuilder<AssessmentQuestion> builder)
        {
            builder.HasKey(p => new { p.AssessmentId, p.QuestionId });

            builder.HasOne(x => x.Question)
                .WithMany()
                .HasForeignKey(x => x.QuestionId);

            builder.HasOne(x => x.Assessment)
                        .WithMany()
                        .HasForeignKey(x => x.AssessmentId);
        }

    }
}
