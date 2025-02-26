using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{/*
    File -> Provides static methods for creating, deleting, copying, moving, and opening files.
    FileInfo -> Provides instance methods for file operations(similar to File class but with more control).
    Directory -> Provides static methods for creating, deleting, and managing directories.
    DirectoryInfo -> Similar to Directory but works with instances.
    StreamReader -> Reads text from a file as a stream.
    StreamWriter -> Writes text to a file as a stream.
    FileStream -> Reads and writes bytes from/to a file.
    BinaryReader -> Reads binary data from a file.
    BinaryWriter -> Writes binary data to a file.
    */
    internal class FileOperationsAdvance
    {
        // **********   File Creation ************
        // 1) using File.Create()  The file will be empty if not written.
        public void CreateFile()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\Ok.txt";
            File.Create(path);
            Console.WriteLine("File 1 created successfully");

        }

        //2) Using FileStream FileMode.Create creates a new file, overwriting if it already exists.

        public void CreateFile2()
        {
            string path1 = @"D:\AcessMeditech\File-IO\File-IO\pujaborse.txt";
            FileStream fs = new FileStream(path1, FileMode.Create);
            Console.WriteLine("File 2 created Successfully ");

        }

        //*********** Writing to a File ***************

        public void WriteFile1()
        {
            //using streamWriter
            using (StreamWriter sw = new StreamWriter(@"D:\AcessMeditech\File-IO\File-IO\textfile.txt"))
            {
                sw.WriteLine("Hello! keep going on puja");

            }
            Console.WriteLine("Data written to file. 1");


            //Using  File.WriteAllText
            File.WriteAllText(@"D:\AcessMeditech\File-IO\File-IO\pujaco1.txt", "Hello, this is a sample text using WriteAllText.");
            Console.WriteLine("Data written  using WriteAllText in file 2 (Overwrites existing content).");

            //Using File.AppendAllText() (For Appending)
            File.AppendAllText(@"D:\AcessMeditech\File-IO\File-IO\pujaco1.txt", "\nThis is appended text in okk file.");
            Console.WriteLine("Data written using Appended method in file ");


        }

        public void ReadFile()
        {

            using (StreamReader sr = new StreamReader(@"D:\AcessMeditech\File-IO\File-IO\pujaco1.txt"))
            {
                //Using ReadToEnd
                string content1 = sr.ReadToEnd(); //ReadToEnd() reads the entire file content.
                Console.WriteLine(content1);

                //using ReadAllText()
                string content2 = File.ReadAllText(@"D:\AcessMeditech\File-IO\File-IO\textfile.txt");
                Console.WriteLine(content2);



                //using Readline
                foreach (string line in File.ReadLines(@"D:\AcessMeditech\File-IO\File-IO\textfile.txt"))
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("Read Using loop"); 

            }
        }

        public void DeleteFile()
        {

            File.Delete(@"D:\AcessMeditech\File-IO\File-IO\textfile-Copy.txt");
            Console.WriteLine("File deleted successfully.");

        }

        //Copy File
        public void CopyFile()
        {
            File.Copy(@"D:\AcessMeditech\File-IO\File-IO\textfile1.txt", @"D:\AcessMeditech\File-IO\File-IO\textfileCopy.txt");
            Console.WriteLine("File copied successfully.");

        }

        //Move file
        public void MoveFile()
        {
            File.Move(@"D:\AcessMeditech\File-IO\File-IO\textfile.txt", @"D:\AcessMeditech\textfile.txt");
            Console.WriteLine("File moved successfully.");

        }

        //Checking if a File Exists
        public void CheckFileExist()
        {
            if (File.Exists(@"D:\AcessMeditech\File-IO\File-IO\textfileCopy.txt"))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

        }


        //____________________________________________________
        //Working with directory
        public void CreateDirectory()
        {
            Directory.CreateDirectory(@"D:\AcessMeditech\File-IO\File-IO\NewFolder");
            Console.WriteLine("Directory created successfully.");


        }


        //Directory exists
        public void DirectoryExist()
        {

            if (Directory.Exists(@"D:\AcessMeditech\File-IO\File-IO\NewFoldero")) 
            {
                Console.WriteLine("Directory exists.");
            }
            Console.WriteLine("Directory not exists.");
        }


        //Delete Directory

        public void DeleteDirectory()
        {
            Directory.Delete(@"D:\AcessMeditech\File-IO\File-IO\NewFolder", true); // 'true' deletes non-empty directories
            Console.WriteLine("Directory deleted.");


        }


        //Getting All Files in a Directory
        public void GetAllFilesinDirectory()
        {
            string[] files = Directory.GetFiles(@"D:\AcessMeditech\File-IO\File-IO");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

        }




    }
}
