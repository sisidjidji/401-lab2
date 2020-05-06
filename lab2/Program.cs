using System;
using System.Runtime.InteropServices.ComTypes;

namespace lab2
{
    class Program
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
                    Decimal withdrow=Withdraw(Balance(), amount);
                        
                    
                }
                else if (menu == "3")
                {
                    Console.WriteLine("Please enter the amount you want to deposit");
                        Decimal amountDeposit = Convert.ToInt32(Console.ReadLine());
                    Decimal deposit= Deposit(Balance(), amountDeposit);
                    
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

        public static Decimal Balance()
        {
            
            return currentBalance;

        }
       public static Decimal Withdraw(Decimal balance,Decimal amount)
        {
            Decimal newBalance;
            
            if(balance==0){
                Console.WriteLine("You don't have enghout Balance");
            }
            if(amount>=balance){
                Console.WriteLine("please enter another amount");
             
                }
            else{
                 newBalance = balance - amount;
                
            }
           return newBalance ; 
        }

        public static Decimal Deposit(Decimal balance, Decimal amount)
        {

            Decimal deposit = balance + amount;

            return deposit;
        }


    }
}
