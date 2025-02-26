// See https://aka.ms/new-console-template for more information



namespace File_IO
{

  class Program
  {
    static void Main(string[] args)
    {
            
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


        }
      }
}