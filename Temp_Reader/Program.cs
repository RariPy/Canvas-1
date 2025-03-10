using System.Security.Cryptography;

namespace Temp_Reader;

class Program
{
    static void Main(string[] args)
    { 
        while (true)
        {
            Console.WriteLine("Select Fahrenheit or Celsius (f/c)"); 
            var input = Console.ReadLine().ToLower().Trim();    

            if (input == "fahrenheit" || input =="f")  
            {
                Console.WriteLine("Select the amount of Farenheit you want converted to celsius");

                if (int.TryParse(Console.ReadLine(), out int FarDegrees))
                {
                    var ConvCels = (FarDegrees - 32) * 5 / 9;
                    Console.WriteLine("temperature is " + ConvCels + "\u00B0C");
                    
                }
                else
                {
                    Console.WriteLine("Invalid Input!!");              
                    Console.WriteLine("Enter Valid Input!!");
        
                }
            }  
             
            if (input == "celsius" || input == "c")
            {
                Console.WriteLine("Select the amount of Celsius you want converted to Fahrenheit");

                if (int.TryParse(Console.ReadLine(), out int CelDegrees))
                {
                    var ConvFar = (CelDegrees * 9 / 5) + 32;
                    Console.WriteLine("temperature is: " + ConvFar + "\u00B0F");
                    
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Enter Valid Input!!");
                }
            }
            
            Console.WriteLine("Do you still want to check more temperatures? (y/n):");
            string restart = Console.ReadLine().ToLower().Trim();
            if (restart=="y" || restart == "yes")
            {
                continue;
            }
            else
            {
                break;
            }
        }
    }
}
