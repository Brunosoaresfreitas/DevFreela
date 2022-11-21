using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectCommentConfigurations : IEntityTypeConfiguration<ProjectComment>
    {
        public void Configure(EntityTypeBuilder<ProjectComment> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder  // Relacionamento com o Project
                .HasOne(p => p.Project)  // Tem um projeto
                .WithMany(p => p.Comments)  // E um projeto tem uma lista de comments
                .HasForeignKey(p => p.IdProject);

            builder  // Relacionamento com o usuário
                .HasOne(p => p.User)  // Tem um usuário
                .WithMany(p => p.Comments)  // E um usuário tem uma lista de comments
                .HasForeignKey(p => p.IdUser);
        }
    }
}
