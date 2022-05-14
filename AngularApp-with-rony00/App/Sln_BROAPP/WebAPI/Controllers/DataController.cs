using BLC;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private IConfiguration _configuration;
        public DataController(IConfiguration configuration)
        {
            _configuration = configuration;
            Console.WriteLine(_configuration["AppSettings:MyDBConnection"]);
        }

        [HttpGet]
        [Route("GetCourts")]
        public List<Court> GetAllCourts()
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = _configuration["AppSettings:MyDBConnection"];
            return oBLC.GetAllCourts();
        }

        //You should always create a complex type (Class) which has properties matching parameters
        [HttpPost]
        [Route("DeleteCourt")]
        public void Delete_Court(Params_Delete_Court i_Params_Delete_Court)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = _configuration["AppSettings:MyDBConnection"];
            oBLC.Delete_Court(i_Params_Delete_Court);
        }


        [HttpPost]
        [Route("AddOrEditCourt")]
        public void Add_Court(Court i_COURT)
        {
            BLC.BLC oBLC = new BLC.BLC();
            oBLC.connStr = _configuration["AppSettings:MyDBConnection"];
            oBLC.Add_Court(i_COURT);
        }
    }
}
