using AppAlunosMedia.Application.Interface;
using AppAlunosMedia.Domain.Entities;
using AppAlunosMedia.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAlunosMedia.Application
{
    public class Jobs : IJobs
    {
        private readonly IServiceMedia _serviceMedia;
        private readonly ICrudStudent _crudStudent;

        public Jobs(IServiceMedia serviceMedia, ICrudStudent crudStudent)
        {
            _serviceMedia = serviceMedia;
            _crudStudent = crudStudent;
        }

        public void JobCalculateMedia()
        {
            _serviceMedia.ValidateMedia();
        }

        public void Create(Student student)
        {
            _crudStudent.Create(student);
        }

        public void Update(Student student)
        {
            _crudStudent.Update(student);
        }

        public void Delete(int RA)
        {
            var student = _crudStudent.GetByRa(RA);
            _crudStudent.Delete(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _crudStudent.GetAll();
        }
    }
}
