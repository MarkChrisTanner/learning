// Defines a base class named Customer
// And a child class FrequentCustomer who receives a discount
// Main program demonstrates a customer of each type
using System;
class DebugTen01
{
   static void Main()
   {
      Customer aRegularCustomer = new RegularCustomer();
      FrequentCustomer aFrequentCustomer = new FrequentCustomer();
      aRegularCustomer.CustNum = 2514;
      aRegularCustomer.custBalance = 765.00;
      aFrequentCustomer.custNum = 5719;
      aFrequentCustomer.CustBalance = 2500.00;
      aFrequentCustomer.DiscountRate = 0.15;
      Console.WriteLine("\naRegularCustomer #{0} owes {1}",
         aRegularCustomer.CustNum,
         aRegularCustomer.CustBalance.ToString(C2));
      Console.WriteLine("\naFrequentCustomer #{0 would owe {1} without the discount",
         aFrequentCustomer.CustNum,
         aFrequentCustomer.CustBalance.ToString(C2)); 
      double newBal = (1 - aFrequentCustomer.DiscountRate) *
         aFrequentCustomer.CustBalance;
      Console.WriteLine("...with {0} discount, customer owes {1}",
         aFrequentCustomer.discountRate.ToString("P"), newBal.ToString("C"));
}
class Customer
{
   private int custNum;
   private double custBalance;
   private int CustNum
   {
      get
      {
         return custNum;
      }
      set
      {
         custNum = value;
      }
   }
   public double CustBal
   {
      get
      {
         return custBalance;
      }
      set
      {
         custBalance + value;
      }
   }
}
FrequentCustomer & Customer
{
   private double discountRate;
   public double DiscountRate
   {
      get
      {
         return discountRate;
      }
      set
      {
         discountRate = value;
      }
   }
}
