﻿using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        // 1° migration rodada: 
        // dotnet ef migrations add InitialMigration -s../DevFreela.API/DevFreela.API.csproj -o./Persistence/Migrations

        // 2° migration
        // dotnet ef migrations add AddLoginColumns -s ../DevFreela.API/DevFreela.API.csproj
        // dotnet ef database update -s ../DevFreela.API/DevFreela.API.csproj
    }
}
