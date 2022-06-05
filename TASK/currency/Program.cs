string[] command = { "/show-recent-currency-rates", "/find-currency-rate-by-code", "/calculate-amount-by-currecy", "/exit" };
for (int i = 0; i < command.Length; i++)
{
    Console.WriteLine(command[i]);
}
string[] currencycommand = { "USD", "EURO", "TL" };
float[] currencyPrice = { 1.7f, 1.82f, 0.1f };

Console.WriteLine("Meblegi daxil et :");
double amount = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < currencyPrice.Length; i++)
{
    Console.WriteLine($"{currencyPrice[i]}-{currencycommand[i]}");
}
Console.WriteLine("----------------Welcome");
Console.WriteLine("you can use the commands ");
while (true)
{

    string x = Console.ReadLine();
    if (x == command[0])
    {
        for (int i = 0; i < currencyPrice.Length; i++)
        {
            Console.WriteLine($"{currencyPrice[i]}-{currencycommand[i]}");
        }


    }
    else if (x == command[3])
    {
        Console.WriteLine("Thank You");
        break;
    }
    else if (x == command[1])
    {
        string y = Console.ReadLine();

        for (int i = 0; i < currencycommand.Length; i++)
        {
            if (y == currencycommand[i])
            {
                Console.WriteLine(currencyPrice[i]);
            }
        }
    }
    else if (x == command[2])
    {
        string z = Console.ReadLine();
        for (int i = 0; i < currencycommand.Length; i++)
        {
            if (z == currencycommand[i])
            {
                Console.WriteLine(amount / currencyPrice[i]);

            }
        }
    }
    else
    {
        for (int i = 0; i < command.Length; i++)
        {
            Console.WriteLine(command[i]);
        }
        Console.WriteLine("use these commands");
    }
}
