using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using CsvHelper;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace File_IO
{
    internal class JSONFileOperations
    {
        //Create JSON file
        public void CreateFile()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\Employee.json";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("JSON File created successfully");
            }
        }

        //Write data in CSV File
        public void JSONWrite()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\Employee.json";
            var EmpData = new List<Employee> {
            new Employee { EmpId=101, EmpName="Puja",Salary=5600},
            new Employee{ EmpId=102, EmpName="Asmita",Salary=6000},
            new Employee { EmpId=103, EmpName="Komal",Salary=7000}
            };


            string jsonData = JsonConvert.SerializeObject(EmpData, Formatting.Indented);
            File.WriteAllText(path, jsonData);
            Console.WriteLine("Data written in JSON FILE  sucessfully");
        }


        //Read data From CSV File 
        public void JSONReadLines()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\Employee.json";
            string jsonRead = File.ReadAllText(path);
            var deserializedData = JsonConvert.DeserializeObject<List<Employee>>(jsonRead);

            foreach (var record in deserializedData)
            {
                Console.WriteLine($"EmpId ={record.EmpId}, EmpName={record.EmpName}, Salary = {record.Salary}");
            }
        }


        //create copy of CSV File
        public void CopyJSONFile()
        {
            string orignalPath = @"D:\AcessMeditech\File-IO\File-IO\Employee.json";
            string destinationPath = @"D:\AcessMeditech\File-IO\File-IO\EmployeeCopy.json";

            File.Copy(orignalPath, destinationPath);
            Console.WriteLine("File copied successfully.");
        }


        //Detete CSV File 
        public void DeleteCSVFile()
        {
            File.Delete(@"D:\AcessMeditech\File-IO\File-IO\Employee.json");
            Console.WriteLine("File deleted successfully.");
        }

        




      
    } 
}



  