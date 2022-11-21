using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        // Aqui eu estou definindo todas as funcionalidades do meu ProjectController da API

        // ViewModel -> Métodos de saída
        // InputModel -> Métodos de entrada

        // Método Get do ProjectController da API
        List<ProjectViewModel> GetAll(string query);

        // Método GetById do ProjectController da API
        ProjectDetailsViewModel GetById(int id);

        // Método Post do ProjectController da API
        int Create(NewProjectInputModel inputModel);

        // Método Put do ProjectController da API
        void Update(UpdateProjectInputModel inputModel);

        // Método Delete do ProjectController da API
        void Delete(int id);

        // Método PostComment do ProjectController da API
        void CreateComment(CreateCommentInputModel inputModel);

        // Método Start do ProjectController da API
        void Start(int id);

        // Método Finish do ProjectController da API
        void Finish(int id);
    }
}
