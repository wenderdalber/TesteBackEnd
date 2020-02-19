using AppAlunosMedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAlunosMedia.Domain.Interfaces
{
    public interface ITodoRepository
    {
        void Create(Student student);
        void Update(Student student);
        void Delete(Student student);
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetByStatus(string status);
        Student GetByName(string name);
        Student GetByRA(int RA);
        IEnumerable<Student> GetByCourse(string course);
    }
}
