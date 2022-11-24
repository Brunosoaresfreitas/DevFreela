using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateProject
{
    public class CreateProjectsCommandHandler : IRequestHandler<CreateProjectCommand, int>
        // Os parametros são o próprio command e o tipo de resposta que está no command (retorno)
    {
        private readonly DevFreelaDbContext _dbContext;

        public CreateProjectsCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext; 
        }


        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project(request.Title, request.Description, request.IdClient, request.IdFreelancer, request.TotalCost);

            await _dbContext.Projects.AddAsync(project);
            await _dbContext.SaveChangesAsync();

            return project.Id;
        }
    }
}
