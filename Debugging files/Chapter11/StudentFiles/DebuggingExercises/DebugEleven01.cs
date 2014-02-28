// Handles a Format Exception if user does not enter a number
using System;
class DebugEleven01
{
   static void Main()
   {
      double salary;
      string salVal;
      bool isValidSalary;
      while(!isValidSalary)
      {
         try
            Console.Write("Enter an employee's salary ");
            salVal = Console.ReadLine();
            salary = Convert.ToDouble(salVal);
            isValidSalary = true;
         catch(Formatexception fe)
         {
            Console.WriteLine
               ("You must enter a number for the salary");
         }
      }
      Console.WriteLine("The salary {0} is valid", salary.ToString("C2"));
   }
}
