using AppAlunosMedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAlunosMedia.Application.Interface
{
    public interface IJobs
    {
        void JobCalculateMedia();
        void Create(Student student);
        void Update(Student student);
        void Delete(int RA);
        IEnumerable<Student> GetAll();
    }
}
