using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Commands.CreateProject
{
    public class CreateProjectsCommandHandler : IRequestHandler<CreateProjectCommand, int>
        // Os parametros são o próprio command e o tipo de resposta que está no command (retorno)
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectsCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository; 
        }


        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Project(request.Title, request.Description, request.IdClient, request.IdFreelancer, request.TotalCost);

            await _projectRepository.AddAsync(project);
            
            return project.Id;
        }
    }
}
