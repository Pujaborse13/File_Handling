// See https://aka.ms/new-console-template for more information
using File_IO;

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

        
    }
}