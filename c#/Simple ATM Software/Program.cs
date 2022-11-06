namespace Simple_ATM_Software;

internal class Program
{
    private static int state = -1;
    private static int attemps;
    private static Boolean verified = false;

    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        var person = new Person("79927398713", "1234",1000.50);
        var atm = new ATM();

        while (true)
            switch (state)
            {
                // pin state
                case 0:
                    if (!verified)
                    {
                        attemps++;
                        if (attemps == 4)
                        {
                            state = -1;
                            Main();
                        }
                        Console.WriteLine("Enter your PIN...");
                        if (person.GetPin() != Console.ReadLine())
                        {
                            Console.Clear();
                            Console.WriteLine("Pin invalid... You have " + (3 - attemps) + " left");
                            Main();
                        }

                        verified = true;
                    }
                    
                    Console.Clear();
                    Console.WriteLine(" 1. Check balance \n 2. See last transactions \n 3. Take out money");
                    String choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        state = 1;
                    }
                    if (choice == "2")
                    {
                        state = 2;
                    }
                    if (choice== "3")
                    {
                        state = 3;
                    }

                    break;
                // Check balance state
                case 1:
                    Console.WriteLine("Your balance is: \u20AC" + person.GetBalance());
                    Console.ReadLine();
                    state = 0;
                    break;
                // Last transactions state
                case 2:
                    Console.WriteLine("last transactions state");
                    break;
                // Take out money state
                case 3:
                    Console.WriteLine("take out money state");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Welcome to the ATM...");
                    Console.WriteLine("Enter your creditcard: ");
                    string creditcard = Console.ReadLine();
                    if (!atm.checkCreditcard(creditcard) && person.GetCreditcard() != creditcard)
                    {
                        Console.WriteLine("Creditcard invalid...");
                        Main();
                    }

                    state = 0;
                    break;
            }
    }
}