using AppAlunosMedia.Domain.Context;
using AppAlunosMedia.Domain.Entities;
using AppAlunosMedia.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppAlunosMedia.Domain.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ContextApp _context;

        public TodoRepository(ContextApp context)
        {
            _context = context;
        }

        public void Create(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Student
                    .AsNoTracking()
                    .OrderBy(x => x.Name);
        }

        public IEnumerable<Student> GetByCourse(string course)
        {
            return _context.Student
                    .AsNoTracking()
                    .Where(x => x.Course == course)
                    .OrderBy(x => x.Name);
        }

        public Student GetByName(string name)
        {
            return _context.Student
                    .FirstOrDefault(x => x.Name == name);
        }

        public Student GetByRA(int RA)
        {
            return _context.Student
                    .FirstOrDefault(x => x.RA == RA);
        }

        public IEnumerable<Student> GetByStatus(string status)
        {
            return _context.Student
                    .AsNoTracking()
                    .Where(x => x.Status == status)
                    .OrderBy(x => x.Name);
        }

        public void Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            _context.Student.Remove(student);
            _context.SaveChanges();
        }
    }
}
