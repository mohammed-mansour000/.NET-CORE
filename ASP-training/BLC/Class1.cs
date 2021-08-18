using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;


namespace BLC
{
    public class Business
    {
        public IConfiguration _config;
        public Business(IConfiguration config)
        {
            _config = config;
        }
 
        public void AddStudent(Student s)
        {
            string str_filePath = string.Format(@"{0}\{1}.txt", _config["DATA_FOLDER"], s.id); //generating the path, with name id of the text file
            string str_fileContent = string.Format("{0},{1}", s.id, s.name); //generating the file content
            System.IO.File.WriteAllText(str_filePath, str_fileContent); // create the file with the path(1st param) and content (2nd param)
        }

        public void EditStudent(Student s)
        {
            string str_filePath = string.Format(@"{0}\{1}.txt", _config["DATA_FOLDER"], s.id); //generating the path, with name id of the text file
            string str_fileContent = string.Format("{0},{1}", s.id, s.name); //generating the file content
            System.IO.File.WriteAllText(str_filePath, str_fileContent); // create the file with the path(1st param) and content (2nd param)
        }

        public void DeleteStudent(Params_DeleteStudent p)
        {
            string str_filePath = string.Format(@"{0}/{1}.txt", _config["DATA_FOLDER"], p.id); //id presents file's name so we get it's path
            if (System.IO.File.Exists(str_filePath)) //check if file with the str_filePath is exists
            {
                System.IO.File.Delete(str_filePath); // delete the file
            }

        }

        public Student GetSingleStudent()
        {
            var s = new Student();
            s.id = 1;
            s.name = "name";
            return s;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            string[] files = System.IO.Directory.GetFiles(_config["DATA_FOLDER"]); //get all pathes of files exists in certain path
            if (files != null)
            {
                foreach (var file in files)
                {
                    string fileContent = System.IO.File.ReadAllText(file);
                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        string[] parts = fileContent.Split(",");
                        if (parts != null)
                        {
                            var s = new Student();
                            s.id = Convert.ToInt32(parts[0]);
                            s.name = parts[1];
                            students.Add(s);
                        }
                    }
                }
            }
            return students;
        }
    }
}

public class Student
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Params_DeleteStudent
{
    public int id { get; set; }
}
