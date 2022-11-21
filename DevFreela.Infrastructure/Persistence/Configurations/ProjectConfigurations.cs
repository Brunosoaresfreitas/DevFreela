using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;
using System.Reflection.Emit;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {            
            builder
                .HasKey(p => p.Id);

            builder  // Relacionamento com o Cliente
                .HasOne(p => p.Freelancer)  // Cada projeto tem um freelancer
                .WithMany(f => f.FreelanceProjects)  // E um freelancer tem vários projetos
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            builder  // Relacionamento com o Cliente
                .HasOne(p => p.Client)  // Cada projeto tem um cliente
                .WithMany(f => f.OwnedProjects)  // e um cliente tem vários projetos
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
