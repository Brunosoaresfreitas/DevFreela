﻿using DevFreela.Core.Repositories;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public interface IUnitOfWork
    {
        IProjectRepository Projects { get; }
        IUserRepository Users { get; }
        ISkillRepository Skills { get; }
        Task<int> CompleteAsync();
        Task BeginTrancationAsync();
        Task CommitAsync();
    }
}
