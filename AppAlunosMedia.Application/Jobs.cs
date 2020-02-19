using AppAlunosMedia.Application.Interface;
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
    }
}
