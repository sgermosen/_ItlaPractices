decimal result;
int typedOperation;
decimal typedNumber1;
decimal typedNumber2;


Console.WriteLine("Welcome to The Best Calculator");
Console.WriteLine("Type one number that represent your option:");
Console.WriteLine("1. Sum, 2. Substract, 3. Multiplication, 4. Division, 5. Exit");

try
{


    //string typedOperationInString = Console.ReadLine();
    //int typedOperation =  Convert.ToInt32(typedOperationInString);
    //int typedOperation = int.Parse(typedOperationInString);
    //try
    //{
        typedOperation = Convert.ToInt32(Console.ReadLine());
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"The typed option is not valid!!!: {ex.Message}");
        //  throw; 
          //typedOperation=1; 
    //}
    //finally
    //{
    //    Console.WriteLine("I Passed here");

    //}

    Console.WriteLine("Type the first number");

    //try
    //{
    typedNumber1 = Convert.ToDecimal(Console.ReadLine());
    //}
    //catch (Exception)
    //{
    //Console.WriteLine("The typed option is not valid!!!");
    //    throw;
    //}
    Console.WriteLine("Type the second number");
    //try
    //{
    typedNumber2 = Convert.ToDecimal(Console.ReadLine());
    //}
    //catch (Exception)
    //{
    //Console.WriteLine("The typed option is not valid!!!");
    //   throw;
    //}

    // (==) (!=) (<>) (<) (>) (<=) (>=)


    //Multiples ifs to solve a situation
    //if (typedOperation == 1)
    //{
    //    result = typedNumber1 + typedNumber2;
    //}
    //if (typedOperation == 2)
    //{
    //    result = typedNumber1 - typedNumber2;
    //}
    //if (typedOperation == 3)
    //{
    //    result = typedNumber1 * typedNumber2;
    //}
    //if (typedOperation == 4)
    //{
    //    result = typedNumber1 / typedNumber2;
    //}


    //nested ifs to mess everything
    //if (typedOperation == 1)
    //{
    //    result = typedNumber1 + typedNumber2;
    //}
    //else
    //{
    //    if (typedOperation == 2)
    //    {
    //        result = typedNumber1 - typedNumber2;
    //    }
    //    else
    //    {
    //        if (typedOperation == 3)
    //        {
    //            result = typedNumber1 * typedNumber2;
    //        }
    //        else
    //        {
    //            if (typedOperation == 4)
    //            {
    //                result = typedNumber1 / typedNumber2;
    //            }
    //            // if (typedOperation == 5)
    //            //{
    //            //    result = 0;
    //            //}
    //            else
    //            {
    //                result = 0;
    //            }
    //        }
    //    }
    //}


    //If with else ifs to simplify questions
    //if (typedOperation == 1)
    //{
    //    result = typedNumber1 + typedNumber2;
    //}
    //else if (typedOperation == 2)
    //{
    //    result = typedNumber1 - typedNumber2;
    //}
    //else if (typedOperation == 3)
    //{
    //    result = typedNumber1 * typedNumber2;
    //}
    //else if (typedOperation == 4)
    //{
    //    result = typedNumber1 / typedNumber2;
    //}
    ////else if (typedOperation == 5)
    ////{
    ////    result = 0;
    ////}
    //else
    //{
    //    result = 0;
    //}

    switch (typedOperation)
    {
        case 1:
            result = typedNumber1 + typedNumber2;
            break;
        case 2:
            result = typedNumber1 - typedNumber2;
            break;
        case 3:
            result = typedNumber1 * typedNumber2;
            break;
        case 4:
            //try
            //{
            result = typedNumber1 / typedNumber2;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"No se puede dividir entre cero: {ex.Message}");
            //    result = 0;
            //}

            break;
        default:
            result = 0;
            break;
    }
    Console.WriteLine($"The operation Result is: {result}");

}
catch (FormatException ex)
{
    Console.WriteLine($"Usted digitó algo mal: {ex.Message}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"No se puede dividir entre cero: {ex.Message}");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"No se puede dividir entre cero: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"There was an error in the program: {ex.Message}");
    //throw;
}
