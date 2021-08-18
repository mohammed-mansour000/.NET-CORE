 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_training_week_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        IConfiguration _config;
        BLC.Business _blc;
        public DataController(IConfiguration config) //in order to use variables inside appsettings.json --its dependency injection
        {
            _config = config;
            _blc = new BLC.Business(config);
            //_blc._config = config;
        }

        [Route("addStudent")]
        [HttpPost]
        public void AddStudent(Student s)
        {
            _blc.AddStudent(s);
        }

        [Route("editStudent")]
        [HttpPost]
        public void EditStudent(Student s)
        {
            _blc.EditStudent(s);
        }

        [Route("deleteStudent/")]
        [HttpDelete]
        public void DeleteStudent(Params_DeleteStudent p)
        {
            _blc.DeleteStudent(p);
            
        }

        [Route("getStudent")]
        public Student GetSingleStudent()
        {
            return _blc.GetSingleStudent();
        }

        [Route("getStudents")]
        public List<Student> GetAllStudents()
        {
            return _blc.GetAllStudents();
        }
    }
}
