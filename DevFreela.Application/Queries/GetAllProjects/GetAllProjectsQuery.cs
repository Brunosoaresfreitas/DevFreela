using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Core.Models;
using MediatR;
using System.Collections.Generic;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQuery : IRequest<PaginationResult<ProjectViewModel>>
    {
        public string? Query { get; set; }
        public int page { get; set; } = 1;
    }
}
