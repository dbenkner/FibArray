// Calulate the Fib sequeance up to 92.
fibMenu();
void fibCalc(int num)
{
    long[] fibArray = new long[num + 1];
    fibArray[0] = 0;
    fibArray[1] = 1;
    for (int i = 2; i < fibArray.Length; i++)
    {
        fibArray[i] = fibArray[i - 2] + fibArray[i - 1];
        Console.WriteLine(fibArray[i] + " " + i);
    }
}
void fibMenu()
{
    bool menu = true;
    do
    {
        Console.WriteLine("To what number would you like to calculate the fibanoici sequance?");
        var howManyStr = Console.ReadLine();
        int howMany = validNum(howManyStr);
        fibCalc(howMany);
        Console.WriteLine("Would you like to calculate another number? Y/N");
        var again = Console.ReadLine();
        if (again != "Y" &&  again != "y")
        {
            menu = false;
        }
        else if (again == "Y" || again == "y")
        {
            menu = true;
        }
    } while (menu == true);
}
int validNum(string numValid)
{
    int howMany;
    bool isValid = false;
    do
    {
        if (int.TryParse(numValid, out howMany) && howMany <= 92 && numValid != null)
        {
            isValid = true;
        }
        else if (int.TryParse(numValid, out howMany) && (howMany > 92) && numValid != null)
        {
            Console.WriteLine($"The Number {numValid} is too lrage please enter a number lese than 92!");
            numValid = Console.ReadLine();
        }
        else if (numValid == null)
        {
            Console.WriteLine("Please enter a number!");
            numValid = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Please enter a number!");
            numValid = Console.ReadLine();
        }
    } while (isValid == false);
    return howMany;
}