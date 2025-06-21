List<decimal> typedNumbers = new List<decimal>();

decimal result = 0;
int typedOption = 1;
int wantToContinue = 0;
bool running = true;


Console.WriteLine("This is the best calculator");

while (running)
{
    DisplayHeader();

    try
    {
        typedOption = Convert.ToInt32(Console.ReadLine());

        if (typedOption == 5)
        { running = false; }
        else
        {
            Console.WriteLine("Please Type the first number");
            typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Please Type the second number");
            typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

            while (wantToContinue != 2)
            {
                Console.WriteLine("you want to continue inserting numbers? 1. Yes, 2. No");
                wantToContinue = Convert.ToInt32(Console.ReadLine());
                if (wantToContinue == 1)
                {
                    Console.WriteLine("Please Type another number");
                    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
                }
            }

            switch (typedOption)
            {
                case 1:
                    {
                        result = SumList(typedNumbers);
                    }
                    break;
                case 2:
                    foreach (int typedNumber in typedNumbers)
                    {
                        result -= typedNumber;
                    }

                    break;
                case 3:
                    foreach (int typedNumber in typedNumbers)
                    {
                        result *= typedNumber;
                    }

                    break;
                case 4:
                    foreach (int typedNumber in typedNumbers)
                    {
                        result /= typedNumber;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine($"The Result of the operation is:{result}");


        }
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"you can not divide by zero: {ex.Message}");
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine($"you can not divide by zero: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Closing Db Conection");
    }

}

//procceess
static void MakeSumByRef(ref decimal valueToModify, decimal value)
{
    valueToModify += value;
}

//function
static decimal MakeSum(decimal valueToModify, decimal value)
{
    valueToModify += value;
    return valueToModify;
    // return string.Empty
}

static decimal SumList(List<decimal> typedNumbers)
{
    decimal result = 0;
    foreach (int typedNumber in typedNumbers)
    {
     
        result = MakeSum(result, typedNumber);
        //  MakeSumByRef(ref result, typedNumber);
        // result += typedNumber;
    }
    typedNumbers[0] = 1;
    return result;
}

static void DisplayHeader()
{
    Console.WriteLine("Please Type the option number than you want");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("1. Sum, \n2. Substract,  \n3. Multiplication,  \n4. Division,  \n5. Exit");
}
