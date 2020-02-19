using AppAlunosMedia.Domain.Entities;
using AppAlunosMedia.Domain.Interfaces;
using AppAlunosMedia.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAlunosMedia.Infra.Services
{
    public class CrudStudent : ICrudStudent
    {
        private readonly ITodoRepository _todoRepository;

        public CrudStudent(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public void Create(Student student)
        {
            _todoRepository.Create(student);
        }

        public void Update(Student student)
        {
            _todoRepository.Update(student);
        }

        public void Delete(Student student)
        {
            _todoRepository.Delete(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return _todoRepository.GetAll();
        }

        public Student GetByName(string name)
        {
            return _todoRepository.GetByName(name);
        }

        public Student GetByRa(int RA)
        {
            return _todoRepository.GetByRA(RA);
        }

        public IEnumerable<Student> GetByStatus(string status)
        {
            return _todoRepository.GetByStatus(status);
        }

        public IEnumerable<Student> GetByCourse(string course)
        {
            return _todoRepository.GetByCourse(course);
        }
    }
}
