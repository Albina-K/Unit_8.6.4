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


namespace Unit_8_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\\User\\Luft\\SkillFactoryNew\\students.dat";
            static List<Student> ReadStudents()
            {
                var students = new List<Student>();

                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        var student = new Student()
                        {
                            Name = reader.ReadString(),
                            Group = reader.ReadString(),
                            DateOfBirth = DateTime.FromBinary(reader.ReadInt64()),
                            Grade = reader.ReadDecimal()
                        };

                        students.Add(student);
                    }
                }

                return students;


            }
        }

    }
    public class Student
    { 
            public string Name { get; set; }
            public string Group { get; set; }
            public DateTime DateOfBirth { get; set; }
            public decimal Grade { get; set; }
    }

    public class Person
    {
        string filePath = @"C:\\User\\Luft\\SkillFactoryNew\\students.dat";
        public List<Student> ReadStudents()
        {
            var students = new List<Student>();

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    var student = new Student()
                    {
                        Name = reader.ReadString(),
                        Group = reader.ReadString(),
                        DateOfBirth = DateTime.FromBinary(reader.ReadInt64()),
                        Grade = reader.ReadDecimal()
                    };

                    students.Add(student);
                }
            }

            return students;
            

        }


    }
    
}

