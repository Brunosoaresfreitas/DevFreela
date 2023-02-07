using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Core.Models;
using Moq;
using Xunit;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreeProjectsExists_Executed_ReturnThreeProjectsViewModels()
        {
            // Arrange
            var projects = new PaginationResult<Project>
            {
                Data = new List<Project>
                {
                new Project("Nome Do Teste 1", "Descrição do teste 1", 1, 2, 10000),
                new Project("Nome Do Teste 2", "Descrição do teste 2", 1, 2, 20000),
                new Project("Nome Do Teste 3", "Descrição do teste 3", 1, 2, 30000),
                }
            };

            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetAllAsync(It.IsAny<string>(), It.IsAny<int>()).Result).Returns(projects);

            var getAllProjectQuery = new GetAllProjectsQuery { Query = "", page = 1};
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoryMock.Object);

            // Act
            var paginationProjectViewModelList = await getAllProjectsQueryHandler.Handle(getAllProjectQuery, new CancellationToken());


            // Assert
            Assert.NotNull(paginationProjectViewModelList);
            Assert.NotEmpty(paginationProjectViewModelList.Data);
            Assert.Equal(projects.Data.Count, paginationProjectViewModelList.Data.Count);

            projectRepositoryMock.Verify(pr => pr.GetAllAsync(It.IsAny<string>(), It.IsAny<int>()).Result, Times.Once);
        }
    }
}
