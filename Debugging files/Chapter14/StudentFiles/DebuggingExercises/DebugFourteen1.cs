using System;
using System.IO;
class DebugFourteen1
{
   static void Main()
   {
      string fileName;
      string directory;
      string path;
      string[] files;
      int x;
      Console.Write("Enter a directory ");
      directory = Console.ReadLine();
      if(Directory.exists(directory))
      {
          files = Directory.GetFiles(directory);
          if(files.Length = 0)
              Console.WriteLine("There are no files in " + directory);
          else
          {
             Console.WriteLine(directory + " contains the following files");
             for(x = 0; x < 20; ++x)
                 Console.WriteLine("  " + files[x]);
             Console.Write("\nEnter a file name ");
             fileName = Console.ReadLine();
             path = directory + "\\" + fileName;
             if(File.Exists(path))
             {
                Console.WriteLine("  File exists and was created " + File.GetCreationTime(path));
                Console.WriteLine("File was created " +
                File.GetCreationtime(fileName));
                Console.WriteLine("File was last accessed " +
                File.GetLastAccesstime(fileName));
                Console.WriteLine("File was last written to " +
                File.GetLastWriteTime(fileName));
             }
             else
                 Console.WriteLine("  " + fileName + " does not exist in the " + directory + " directory");
             
         }
      }
      else
      {
          Console.WriteLine("Directory " + directory + " does not exist");
      }
  }
}