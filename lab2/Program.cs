using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("welcome to your  ATM app ");

            while (true)
            {
                try{
                Console.WriteLine("press 1 for Current Balance\n");
                Console.WriteLine("press 2 for  Withdraw \n");
                Console.WriteLine("press 3 for  Deposit \n");
                Console.WriteLine("press 4 to exit  \n");
                string menu = Console.ReadLine();

                if (menu == "1")
                {
                    Decimal balance=Balance();
                    Console.WriteLine($"Your balance is {balance}");
                }
                else if (menu == "2")
                {

                    Console.WriteLine("Please enter the amount you want");
                    Decimal amount = Convert.ToInt32(Console.ReadLine());
                    Withdraw(amount);
                    
                }
                else if (menu == "3")
                {
                    Console.WriteLine("Please enter the amount you want to deposit");
                        Decimal amountDeposit = Convert.ToInt32(Console.ReadLine());
                        Deposit(amountDeposit);
                    
                }

                else
                {
                    break;
                }
                }
                catch(FormatException ex){

                    Console.WriteLine(" Not a valid number. Please try again." ,ex.Message);

                }

            }
        }

        static Decimal currentBalance = 5000.00m;
        public static Decimal Balance()
        {
            
            return currentBalance;

        }
       public static Decimal Withdraw(Decimal amount)
        {
            
            
            if(currentBalance==0){
                Console.WriteLine("You don't have enghout Balance");
            }
            if(amount>currentBalance){
                Console.WriteLine("please enter another amount");
             
                }
            else{
                 currentBalance = currentBalance - amount;
                
            }
            return currentBalance; 
        }

        public static Decimal Deposit(Decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("please enter another amount");
            }
            else
            currentBalance = currentBalance+ amount;

            return currentBalance;
        }


    }
}
