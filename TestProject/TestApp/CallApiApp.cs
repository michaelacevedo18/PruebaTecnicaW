public class CallApiappClass
{
    static void Main(string[] args)
    {
        int attempts = 10;
        int successAt = 0; 
        int winNum = ServiceMockApiCall(); 

        // 10 intentos
        for (int i = 0; i < attempts; i++)
        {
            Console.WriteLine($" Atemp {i + 1} of {attempts}: Input one number (4 figures): ");
            
            int atempNum = NumberValid();
                        
            if (winNum == atempNum)
            {
                successAt++; 

                Console.WriteLine("You won!");

                if (successAt == 10)
                {
                    Console.WriteLine("Begin 10 atemps more");
                    successAt = 0; 
                    winNum = ServiceMockApiCall();
                }
            }
            else
            {
                if (i == 9) 
                {
                    Console.WriteLine($"You are Lost the correct number was {winNum}");
                }
            }
        }

        Console.WriteLine("Tanks Atemp Again");
    }

    //As the granted API didn't respond i simulate the service
    static int ServiceMockApiCall()
    {
        Random rand = new();
        return rand.Next(1000, 9999);
        //return 9999;
    }

    static int NumberValid()
    {
        int number;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number) && input.Length == 4 && number != 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Your number isn't valid, it should be of 4 figures.");
            }
        }
        return number;
    }

   
}
