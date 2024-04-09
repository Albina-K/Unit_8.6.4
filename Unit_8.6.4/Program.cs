using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Unit_8_6_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\\User\\Luft\\SkillFactoryNew\\students.dat";
            // var fileInfo = new FileInfo(filePath);
            string Name;
            string Group;
            long DateOfBirth;
           // DataTime DateOfBirth;
            decimal Grade;
            if (File.Exists(filePath)) 
            {
                //string stringValue;
                
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open))) 
                {
                    Name = reader.ReadString();
                    Group = reader.ReadString(); 
                    DateOfBirth = reader.ReadInt64(); ;
                    // DataTime DateOfBirth;
                    decimal Grade;
                }

                Console.WriteLine(stringValue);
              /*  try
                {
                    string filePath2 = @"C:\\User\\Luft\\SkillFactoryNew\\student.dat";
                    var fileInfo2 = new FileInfo(filePath2);

                    fileInfo2.Delete();

                    fileInfo.CopyTo(filePath2);
                    Console.WriteLine($"{filePath} скопирован {filePath2}");

                    fileInfo.Delete();
                    Console.WriteLine($"{filePath} удален");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e}");
                }*/
            }
        }
    }
}
