using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;


namespace Unit_8_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\User\\Luft\\SkillFactoryNew\\students.dat";
            string filePath2 = "C:\\Users\\Альбина\\Desktop\\Students";
            //    directory.CreateSubdirectory("Students");

            List<Student> students = ReadStudent(filePath);

            foreach (Student student in students)
            {
                File.CreateText(filePath2 + "\\" + student.Group + ".txt");
            }
            WriteStudent(students, filePath2);


        }
        static void WriteStudent(List<Student> students, string path)
        {
            var fs = new FileStream(path, FileMode.Open);
            var fileGroup = Directory.GetFiles(path);

            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (Student student in students)
                {
                    foreach (string file in fileGroup)
                        if (student.Group == file)
                        {
                            writer.Write(student.Name);
                            writer.Write(student.DateOfBirth);
                            writer.Write(student.Grade);
                        }
                }

            }
        }

        //static void СreatingAFolder()
        //{
        //    DirectoryInfo directory = new DirectoryInfo("C:\\Users\\Альбина\\Desktop");
        //    directory.CreateSubdirectory("Students");
        //}

        static List<Student> ReadStudent(string filePath)
        {
            List<Student> students = new List<Student>();

            var fs = FileStream(filePath, FileMode.Open);

            using (StreamReader sr = new StreamReader(fs))
            {
                fs.Position = 0;
                BinaryReader br = BinaryReader(fs);
                while (sr.BaseStream.Position < reader.BaseStream.Length)
                {
                    var student = new Student()
                    {
                        Student.Name = sr.ReadString(),
                        Group = sr.ReadString(),
                        DateOfBirth = DateTime.FromBinary(reader.ReadInt64()),
                        Grade = reader.ReadDecimal()
                    };
                    students.Add(student);

                }

            }
            return students;
        }
 
        public class Student
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public DateTime DateOfBirth { get; set; }
            public decimal Grade { get; set; }
        }

    }
}
    


