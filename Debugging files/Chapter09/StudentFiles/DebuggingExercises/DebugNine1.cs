// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using System;
class DebugNine1
{
   static void Main()
   {
      HomeworkAssignment course1 = new HomeworkAssignment();
      HomeworkAssignment course2 = new HomeworkAssignment();
      string entryString;
      int exercises;

      // Get info for first class
      Console.Write("What class do you have homework for? ");
      entry = Console.ReadLine();
      course1.className = entryString;
      Console.Write("How many exercises must you complete? ");
      entryString = Console.ReadLine();
      int.TryParse(entryString, exercises);
      exercises = course1.NumberOfExercises;
      
      // Get info for another class
      Console.Write("What class do you have homework for? ");
      entryString = Console.ReadLine();
      course2.className = entrystring;
      Console.Write("How many exercises must you complete? ");
      entryString = Console.ReadLine();
      char.TryParse(entryString, exercises);
      course2.NumberOfExercises = exercises;

      Console.WriteLine("You have {0} minutes of homework for {1}",
            course1.timeToComplete, course1.ClassName);      
      Console.WriteLine("and {0} more minutes for {1}",
            course2.timeToComplete,course2.ClassName);
   }
}
class HomeworkAssignment
{
   private int numberOfExercises;
   private int timeToComplete;
   // 10 minutes to complete each exercise
   private const int TIME_PER_EXERCISE = 10;
   public ClassName {get; set};
   public int NumberOfExercises
   {
      get
      {
         return numberOfexercises;
      }
      set
      {
         numberOfExercises = number;
         CalcCompletionTime();
      }
   }
   public double TimeToComplete
   {
      get
      {
         return timeToComplete;
      }
   }
   private void CalcCompletionTime()
   {
      timeToComplete = numberOfExercises * TIME_PER_EXERCISE;      
   }
}