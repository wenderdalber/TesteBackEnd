using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppAlunosMedia.Application.Interface;
using AppAlunosMedia.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAlunosMedia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IJobs _jobs;

        public ValuesController(IJobs jobs)
        {
            _jobs = jobs;
        }

        [Route("api/v1/create")]
        [HttpPost]
        public string Create([FromBody]Student student)
        {
            student.Status = "notread";
            _jobs.Create(student);
            return "Ok";
        }

        [Route("api/v1/update")]
        [HttpPut]
        public string Update([FromBody]Student student)
        {
            _jobs.Update(student);
            return "Ok";
        }

        [Route("api/v1/delete")]
        [HttpDelete]
        public string Delete(int RA)
        {
            _jobs.Delete(RA);
            return "Ok";
        }

        [Route("api/v1/list")]
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return _jobs.GetAll();
        }
    }
}