using AppAlunosMedia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAlunosMedia.Domain.Context
{
    public class ContextApp : DbContext
    {
        public ContextApp(DbContextOptions<ContextApp> options)
            : base(options)
        { }

        public DbSet<Student> Student { get; set; }
    }
}
