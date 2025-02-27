// See https://aka.ms/new-console-template for more information



namespace File_IO
{

  class Program
  {
    static void Main(string[] args)
    {
            // JSON File Operations

            JSONFileOperations jfo1 = new JSONFileOperations();
            jfo1.CreateFile();

            JSONFileOperations jfo2 = new JSONFileOperations();
            jfo2.JSONWrite();

            JSONFileOperations jfo3 = new JSONFileOperations();
            jfo3.JSONReadLines();

            JSONFileOperations jf04 = new JSONFileOperations();
            jf04.CopyJSONFile();

            JSONFileOperations jf05 = new JSONFileOperations();
            jf05.DeleteCSVFile();
            //_______________________________________________________
            //CSV file Operations
            /*
            CSVFileOperations emp1 = new CSVFileOperations();
            emp1.CreateFile();

            CSVFileOperations emp2 = new CSVFileOperations();
            emp2.CSVWrite();

            CSVFileOperations emp3 = new CSVFileOperations();
            emp3.CSVRead();

            CSVFileOperations emp4 = new CSVFileOperations();
            emp4.CopyCSVFile();

            CSVFileOperations emp5 = new CSVFileOperations();
            emp5.DeleteCSVFile();

            CSVFileOperations jf06 = new CSVFileOperations();
            jf06.AppendCSVData();

            CSVFileOperations jf07 = new CSVFileOperations();
            jf07.SearchEmployee(103);
            */
            //_______________________________________________________


            /*
            //File Exist or not
            FileOperations fe = new FileOperations();
            fe.FileExsitsOrNot();

            //File Read
            FileOperations fRead = new FileOperations();
            fRead.ExistingFileRead();

            //Copy File
            FileOperations fCopy = new FileOperations();
            fCopy.CopyFile();

            //Delete File
            FileOperations fDelete = new FileOperations();
            fDelete.DeleteFile();

        //------------------------------------------------
           //File Operations
        
            FileOperationsAdvance foa = new FileOperationsAdvance();
            foa.CreateFile();

            FileOperationsAdvance foa2 = new FileOperationsAdvance();
            foa2.CreateFile2();

            FileOperationsAdvance foa3 = new FileOperationsAdvance();
            foa3.WriteFile1();

            FileOperationsAdvance foa4 = new FileOperationsAdvance();
            foa4.ReadFile();

            FileOperationsAdvance foa5 = new FileOperationsAdvance();
            foa5.DeleteFile();

            FileOperationsAdvance foa6 = new FileOperationsAdvance();
            foa6.CopyFile();

            FileOperationsAdvance foa7 = new FileOperationsAdvance();
            foa7.MoveFile();

            FileOperationsAdvance foa8 = new FileOperationsAdvance();
            foa8.CheckFileExist();

            //__________________________________________
            // Directory Operations

            FileOperationsAdvance foa9 = new FileOperationsAdvance();
            foa9.CreateDirectory();

            FileOperationsAdvance foa10 = new FileOperationsAdvance();
            foa10.DirectoryExist();

            FileOperationsAdvance foa11 = new FileOperationsAdvance();
            foa11.DeleteDirectory();

            FileOperationsAdvance foa12 = new FileOperationsAdvance();
            foa12.GetAllFilesinDirectory();
            */







        }
    }
}