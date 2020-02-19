using AppAlunosMedia.Domain.Interfaces;
using AppAlunosMedia.Infra.Interface;

namespace AppAlunosMedia.Infra.Services
{
    public class ServiceMedia : IServiceMedia
    {
        private readonly ITodoRepository _todoRepository;

        public ServiceMedia(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        /// <summary>
        /// Método que realiza a validação dos alunos na base que estão
        /// marcados como notrated
        /// caso a nota seja maior que 7 o aluno está aprovado (true)
        /// </summary>
        public void ValidateMedia()
        {
            var students = _todoRepository.GetByStatus("notrated");
            foreach (var student in students)
            {
                var media = student.Note >= 7 ? "aproved" : "reproved";
                var studentDataBase = _todoRepository.GetByRA(student.RA);
                studentDataBase.Status = media;
                _todoRepository.Update(studentDataBase);
            }
        }
    }
}
