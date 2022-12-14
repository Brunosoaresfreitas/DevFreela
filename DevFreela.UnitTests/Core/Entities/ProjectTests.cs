using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using Xunit;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestIfProjectStartWorks()
        {
            var project = new Project("Nome de Teste", "Descrição do teste", 1, 2, 10000);

            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.StartedAt);

            Assert.NotEmpty(project.Title);
            Assert.NotNull(project.Title);

            Assert.NotEmpty(project.Description);
            Assert.NotNull(project.Description);

            project.Start();

            // 1° Parâmetro: Status esperado do projeto
            // 2° Parâmetro: Status real do projeto
            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt); 
        }
    }
}
