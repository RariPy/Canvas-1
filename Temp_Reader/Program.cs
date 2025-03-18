namespace Temp_Reader;
class Program
{
    static void Main(string[] args)
    { 
        while (true)
        //Prompts user to select what unit it wants converted
        {
            Console.WriteLine("What unit do you want to convert Fahrenheit or Celsius (f/c)"); 
            var input = Console.ReadLine().ToLower().Trim();    
            if (input == "fahrenheit" || input =="f")  
            {
                Console.WriteLine("Input the amount of Fahrenheit you want converted to celsius");
                if (int.TryParse(Console.ReadLine(), out int FarDegrees))
                {
                    //Converts and shows the results to user
                    var ConvertCelsius = (FarDegrees - 32) * 5 / 9;
                    Console.WriteLine("temperature is " + ConvertCelsius + "\u00B0C");                   
                }
                else
                {
                    //If user doesnt enter a valid input for example a letter this will restart the code
                    Console.WriteLine("Invalid Input!!");              
                    Console.WriteLine("Enter Valid Input!!");       
                }
            }  
             
            if (input == "celsius" || input == "c")
            {
                Console.WriteLine("Input the amount of Celsius you want converted to Fahrenheit");

                if (int.TryParse(Console.ReadLine(), out int CelsiusValue))
                {
                    var convertFahrenheit= (CelsiusValue * 9 / 5) + 32;
                    Console.WriteLine("temperature is: " + convertFahrenheit + "\u00B0F");                
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
