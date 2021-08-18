using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_training2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [Route("getSingleStudent")]
        public Student GetStudent()
        {
            var s = new Student();
            s.id = 1;
            s.name = "hamzi";
            return s;
        }

        [Route("getAllStudents")]
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                var x = new Student();
                x.id = i;
                x.name = string.Format("name {0}", i);
                students.Add(x);
            }
            students.RemoveAll(x => x.id % 2 == 0);
            return students;
        }

        [Route("getAllUsers")]
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            for (int i = 0; i < 20; i++)
            {
                var u = new User();
                u.id = i;
                u.name = string.Format("name {0}", i);
                u.email = string.Format("{0}@gmail.com", i);
                u.address = new Address();
                u.address.city = string.Format("City {0}", i);
                u.address.street = string.Format("Street {0}", i);
                u.address.suite = string.Format("Suite {0}", i);
                u.address.zipcode = string.Format("Zipcode {0}", i);
                u.address.geo = new Geolocation();
                u.address.geo.lat = 2334.23423;
                u.address.geo.lng = 1213.242424;

                users.Add(u);
            }
            return users;
        }
    }

    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }

    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }

    }

    public class Address
    {
        public string street { get; set; }
        public string  city { get; set; }
        public string suite { get; set; }
        public string zipcode { get; set; }
        public Geolocation geo { get; set; }
    }

    public class Geolocation
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    
}
