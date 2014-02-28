// Declare a Student
// ID must be an integer and gpa must be a double to continue
using System;
class DebugEleven04
{
   static void Main()
   {
      Student stu = new Student();
      bool areNumbersGood = false;
      while(!areNumbersGood)
      {
         try
         {
            stu.setID();
            stu.setGPA();
         }
         catch (FormatException e)
         {
            Console.WriteLine(e.Message);
            Console.WriteLine("(Either the student ID or the GPA");
            Console.WriteLine(" was not in the correct format)");
            Console.WriteLine("You will have to re-enter the student data.");
         }
      }
      Console.WriteLine("Valid student");      }
}
public class Student
{
   private int stuId;
   private double stuGpa;
   public void setID()
   {
      string stuNumber;
      try
      {
         Console.Write("Enter student ID ");
         stuNumber = Console.ReadLine;
         stuId = Convert.ToInt32(stuNumber);
      }
      catch(FormatException fe)
         throw(fe);
   }
   public void setGPA()
   {
      string stuGPAString;
      try
      {
         Console.Write("Enter student GPA ");
         stuGPAString = Console.ReadLine();
         stuGpa = Convert.ToDouble(stuGPAString);
      }
      catch(FormatException fe)
      {
         throw(fe);
      }
   }
}   

   