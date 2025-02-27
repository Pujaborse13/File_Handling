using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    public class FileOperations
    {

        //Check File Exist or not 
        public void FileExsitsOrNot()
        {

            string path = @"D:\AcessMeditech\File-IO\File-IO\puja.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exist ");
            }
            else
            {
                Console.WriteLine("Not file exists");
            }
        }

        //Read Existing File Data 
        public void ExistingFileRead()
        {
            string path = @"D:\AcessMeditech\File-IO\File-IO\puja.txt";
            if (File.Exists(path))
            {

                string[] lines;
                string text1;

                lines = File.ReadAllLines(path);
                text1 = File.ReadAllText(path);

                Console.WriteLine(lines[0]); //read perticuler line
                Console.WriteLine(lines[2]);

                Console.WriteLine(text1);   //Read All data in file 

            }
            else
            {
                Console.WriteLine("File not Exist");
            }
        }


        //Copy Existing file 
        public void CopyFile()
        {
            string path1 = @"D:\AcessMeditech\File-IO\File-IO\puja.txt";
            string newpath2 = @"D:\AcessMeditech\File-IO\File-IO\pujacopy.txt";

            File.Copy(path1, newpath2);
            Console.WriteLine("File Copy Crated");

        }


        //Delete File 
        public void DeleteFile()
        {

            string pathDelete = @"D:\AcessMeditech\File-IO\File-IO\pujaco.txt";
            if (File.Exists(pathDelete))
            {
                File.Delete(pathDelete);
                Console.WriteLine("File Deleted !");
            }
            else {
                Console.WriteLine("File Not Exist to delete");
            }
        }


        //





    }
}
