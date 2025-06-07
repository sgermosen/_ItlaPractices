

//decimal[] decimals = new decimal[5];

//decimals[0] = 123;

//decimals[1]=123;
//decimals[2]=123;
//decimals[3]=123;
//decimals[4]=123;

//decimal [] decimals2 = new decimal[5] {12,23,14,12,12 };
//decimal [] decimals3=   {12,23,14,12,12 };


//Console.WriteLine($"the values on the array are: {decimals[1]},{decimals[2]},{decimals[3]},{decimals[4]},{decimals[0]}");


//decimal[] typedNumbers = new decimal[15000000];
//decimal[] typedNumbers = new decimal[2];
//decimal[] typedNumbers = new decimal[1];
List<decimal> typedNumbers = new List<decimal>();
//typedNumbers.Add(23231234);  

//var result =0m;
decimal result = 0;

int typedOption = 1;

Console.WriteLine("This is the best calculator");

Console.WriteLine("Please Type the option number than you want");

Console.WriteLine("---------------------------------------");
Console.WriteLine("1. Sum, \n2. Substract,  \n3. Multiplication,  \n4. Division,  \n5. Exit");


try
{

    int.TryParse(Console.ReadLine(), out typedOption);


    try
    {
        Console.WriteLine("Please Type the first number");
        // typedNumbers[0] = Convert.ToDecimal(Console.ReadLine());
        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));
    }
    catch (Exception)
    {

        throw;
    }

    //Console.WriteLine("Please Type the second number");
    //typedNumbers[1] = decimal.Parse(Console.ReadLine());

    //var youWantToContinue ;
    int youWantToContinue = 2;

    //Console.WriteLine("Do you want to continue? 1. Yes, 2. No");
    //int.TryParse(Console.ReadLine(), out youWantToContinue);

    //int index = 2;
    //while (youWantToContinue == 1)
    //{
    //    Console.WriteLine("Please Type a new number");
    //    // typedNumbers[index] = decimal.Parse(Console.ReadLine());
    //    var capturedValue = decimal.Parse(Console.ReadLine());
    //    var tempTypedNumbers = typedNumbers;
    //    typedNumbers = new decimal[index + 1];

    //    for (int i = 0; i < tempTypedNumbers.Length; i++)
    //    {
    //        typedNumbers[i] = tempTypedNumbers[i];
    //    }
    //    typedNumbers[index] = capturedValue;
    //    Console.WriteLine("Do you want to continue? 1. Yes, 2. No");
    //    int.TryParse(Console.ReadLine(), out youWantToContinue);
    //    index++;
    //}
    //int index = 1;

    do
    {

        Console.WriteLine("Please Type a new number");
        var capturedValue = decimal.Parse(Console.ReadLine());
        //var tempTypedNumbers = typedNumbers;
        //typedNumbers = new decimal[index + 1];
        //typedNumbers = new decimal[typedNumbers.Length + 1]; 
        //for (int i = 0; i < tempTypedNumbers.Length; i++)
        //{
        //    typedNumbers[i] = tempTypedNumbers[i];
        //}
        //typedNumbers[index] = capturedValue;
        //typedNumbers[typedNumbers.Length - 1] = capturedValue;

        // typedNumbers = typedNumbers.Append(decimal.Parse(Console.ReadLine())).ToArray();

        //decimal[] tempArray = new decimal[typedNumbers.Length + 1];
        //typedNumbers.CopyTo(tempArray, 0);
        //tempArray[tempArray.Length - 1] = decimal.Parse(Console.ReadLine());
        //typedNumbers = tempArray;

        typedNumbers.Add(capturedValue);

        Console.WriteLine("Do you want to continue please press the number of the option than you want? 1. Yes, 2. No");
        int.TryParse(Console.ReadLine(), out youWantToContinue);

        //if (youWantToContinue < 2)
        //{
        //    Console.WriteLine("Yo can not put a option greater than 2");

        //}
        //if (youWantToContinue > 1)
        //{
        //    Console.WriteLine("Yo can not put a option shorter than 1");

        //}
        //if (youWantToContinue == 0)
        //{
        //    Console.WriteLine("Yo need to put the number of the option than you want"); 
        //}

        // and &&     or ||     not  !
        // and
        // v && v = V
        // v && f = F
        // f && v = F
        // f && f = F
        // 

        // or
        // v || v = V
        // v || f = V
        // f || v = V
        // f || f = F
        //

        //not 
        //!(v) = f
        //!(f) = v


        // v && v   && f && v && f || v || f || v && v
        // v        && f && v && f || v || f || v && v
        // f             && v && f || v || f || v && v
        // f                  && f || v || f || v && v
        // f                       || v || f || v && v
        // v                            || f || v && v
        // v                                 || v && v
        // v                                      && v
        // v


        // v && v && (f && v && f || v || f || v && v)

        // v && v && !(f && v && f || v || f || v && v)

        //f                       ||             v
        if (youWantToContinue < 1 || youWantToContinue > 2)
        {
            Console.WriteLine("You need to put a valid option: 1. or 2.");
            youWantToContinue = 2; // Reset to default to exit the loop
        }

        //  index++;
    } while (youWantToContinue == 1);

    //if (youWantToContinue == 2)
    //{
    //    switch (typedOption)
    //    {
    //        case 1:
    //            {
    //                result = typedNumbers[0] + typedNumbers[1];
    //                break;
    //            }
    //        case 2:
    //            result = typedNumbers[0] - typedNumbers[1];
    //            break;
    //        case 3:
    //            result = typedNumbers[0] * typedNumbers[1];
    //            break;
    //        case 4:
    //            result = typedNumbers[0] / typedNumbers[1];
    //            break;
    //        default:
    //            result = 0;
    //            break;
    //    }
    //    Console.WriteLine($"The Result of the operation is:{result}");
    //}
    //else if (youWantToContinue == 1)
    //{
    //    Console.WriteLine("Please Type a new number");
    //    typedNumbers[2] = decimal.Parse(Console.ReadLine());
    //    Console.WriteLine("Do you want to continue? 1. Yes, 2. No");
    //    int.TryParse(Console.ReadLine(), out youWantToContinue);
    //    if (youWantToContinue == 2)
    //    {
    //        switch (typedOption)
    //        {
    //            case 1:
    //                {
    //                    result = typedNumbers[0] + typedNumbers[1];
    //                    break;
    //                }
    //            case 2:
    //                result = typedNumbers[0] - typedNumbers[1];
    //                break;
    //            case 3:
    //                result = typedNumbers[0] * typedNumbers[1];
    //                break;
    //            case 4:
    //                result = typedNumbers[0] / typedNumbers[1];
    //                break;
    //            default:
    //                result = 0;
    //                break;
    //        }
    //        Console.WriteLine($"The Result of the operation is:{result}");
    //    }
    //    else if (youWantToContinue == 1)
    //    {
    //        Console.WriteLine("Please Type a new number");
    //        typedNumbers[2] = decimal.Parse(Console.ReadLine());
    //        Console.WriteLine("Do you want to continue? 1. Yes, 2. No");
    //        int.TryParse(Console.ReadLine(), out youWantToContinue);

    //    }

    //}


    switch (typedOption)
    {
        case 1:
            {
                foreach (var number in typedNumbers)
                {
                    result += number;
                    //result = result + number;
                }
                //result = typedNumbers[0] + typedNumbers[1];
                break;
            }
        case 2:
            foreach (var number in typedNumbers)
            {
                result -= number;
                //result = result + number;
            }
            //result = typedNumbers[0] - typedNumbers[1];
            break;
        case 3:
            foreach (var number in typedNumbers)
            {
                result *= number;
                //result = result + number;
            }
            //result = typedNumbers[0] * typedNumbers[1];
            break;
        case 4:
            foreach (var number in typedNumbers)
            {
                result /= number;
                //result = result + number;
            }
            //  result = typedNumbers[0] / typedNumbers[1];
            break;
        default:
            result = 0;
            break;
    }
    Console.WriteLine($"The Result of the operation is:{result}");


}
catch (DivideByZeroException)
{
    Console.WriteLine($"you can not divide by zero");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"An arimethic exception has occurs");
}
catch (Exception ex)
{
    if (ex.Message.Contains("Input string was not in a correct format"))
    {
        Console.WriteLine($"You need to type a number");
    }
    else
    {
        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    }

}
finally
{
    Console.WriteLine("Closing Db Conection");
}
