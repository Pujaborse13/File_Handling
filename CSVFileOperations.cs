using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace File_IO
{
    internal class CSVFileOperations
    {
        //Create CSV file
        public void CreateFile()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\StudentsCSV.csv";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("CSV File created successfully");

            }
        }
        //Write data in CSV File
        public void CSVWrite()
        {
            var EmpData = new List<Employee> {
            new Employee { EmpId=101, EmpName="Puja",Salary=5600},
            new Employee{ EmpId=102, EmpName="Asmita",Salary=6000},
            new Employee { EmpId=103, EmpName="Komal",Salary=7000}


            };
            string path = @"D:\AcessMeditech\File-IO\File-IO\StudentsCSV.csv";

            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(EmpData);
            }
            Console.Write("Data write sucessfully");
        }

        //Read data From CSV File 
        public void CSVRead()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\employeeCSV.csv";

            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<Employee>();
                foreach (var record in records)
                {
                    Console.WriteLine($"EmpId ={record.EmpId}, EmpName={record.EmpName}, Salary = {record.Salary}");

                }
            }
        }

        //create copy of CSV File
        public void CopyCSVFile()
        {
            string orignalPath = @"D:\AcessMeditech\File-IO\File-IO\StudentsCSV.CSV";
            string destinationPath = @"D:\AcessMeditech\File-IO\File-IO\StudentsCSVCopy.CSV";

            File.Copy(orignalPath, destinationPath);
            Console.WriteLine("File copied successfully.");

        }

        //Detete CSV File 

        public void DeleteCSVFile()
        {

            File.Delete(@"D:\AcessMeditech\File-IO\File-IO\StudentsCSVCopy.CSV");
            Console.WriteLine("File deleted successfully.");

        }

        //Add Records or Append
        public void AppendCSVData()
        {
            var newEmployees = new List<Employee>
            {
                new Employee { EmpId=104, EmpName="Neha", Salary=7500},
                new Employee { EmpId=105, EmpName="Rohit", Salary=8000}
             };

            string path = @"D:\AcessMeditech\File-IO\File-IO\StudentsCSV.csv";

            using (var writer = new StreamWriter(path, append: true))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(newEmployees);
            }
            Console.WriteLine("Data appended successfully.");
        }

        public void SearchEmployee(int empId)
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\StudentsCSV.csv";

            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<Employee>();

                foreach (var emp in records)
                {
                    if (emp.EmpId == empId)
                    {
                        Console.WriteLine($"EmpId={emp.EmpId}, EmpName={emp.EmpName}, Salary={emp.Salary}");
                        return;
                    }
                }

                Console.WriteLine("Employee not found.");
            }
        }

    }




}









  
