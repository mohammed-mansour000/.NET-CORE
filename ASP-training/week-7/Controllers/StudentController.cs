using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using week_7.Model;

namespace week_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {

        private IHubContext<StudentHub> _hub;
        public StudentController(IHubContext<StudentHub> hub)
        {
            _hub = hub;
        }

        [HttpGet]
        [Route("GetResults")]
        public List<Student> GetListResults()
        {
            //StudentManager SM = new StudentManager();
            //return SM.GetResults();

            StudentManager SM = new StudentManager();
            Thread oThread = new Thread(() =>
            {
                KeepSendingResults();
            });
            oThread.Start();
            return SM.GetResults();
        }

        public void KeepSendingResults()
        {
            while (true)
            {
                StudentManager StMgr = new StudentManager();
                _hub.Clients.All.SendAsync("NewResults", StMgr.GetResults());
                Thread.Sleep(3000);
            }
        }

    }
}
