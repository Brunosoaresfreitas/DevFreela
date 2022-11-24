using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.GetAllProjects
{
    public class GetAllProjectsQuery : IRequest<List<ProjectViewModel>>
    {
        public string Query { get; private set; }

        public GetAllProjectsQuery(string query)
        {
            Query = query;
        }
    }
}
