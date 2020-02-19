using AppAlunosMedia.Domain.Entities;
using System.Collections.Generic;

namespace AppAlunosMedia.Infra.Interface
{
    public interface ICrudStudent
    {
        void Create(Student student);
        void Update(Student student);
        void Delete(Student student);
        IEnumerable<Student> GetAll();
        Student GetByName(string name);
        Student GetByRa(int RA);
        IEnumerable<Student> GetByStatus(string status);
        IEnumerable<Student> GetByCourse(string course);
    }
}
