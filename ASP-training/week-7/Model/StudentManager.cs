using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_7.Model
{
    public class StudentManager
    {
        public List<Student> GetResults()
        {
            List<Student> studentList = new List<Student>();
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                var s = new Student();
                s.ID = i;
                s.Name = string.Format("Name{0}", i.ToString());
                s.Pass = (r.Next() % 2 == 0);
                studentList.Add(s);
            }
            return studentList;
        }
    }

    public class StudentHub : Hub
    {
    }
}
