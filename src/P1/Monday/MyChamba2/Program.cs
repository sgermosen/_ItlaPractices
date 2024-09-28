decimal typedNumber1;
decimal typedNumber2;

decimal result;
//string capturedValue;
int typedOption = 1;
Console.WriteLine("This is the best calculator");

Console.WriteLine("Please Type the option number than you want");
Console.WriteLine("1. Sum, 2. Substract, 3. Multiplication, 4. Division, 5. Exit");

try
{
    typedOption = Convert.ToInt32(Console.ReadLine());

    //capturedValue = Console.ReadLine();

    //typedNumber1 = Convert.ToDecimal(capturedValue);
    //typedNumber1 = decimal.Parse(capturedValue);
    //typedNumber1 = Convert.ToDecimal(Console.ReadLine());
    //typedNumber1 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Please Type the first number");
    typedNumber1 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Please Type the second number");
    typedNumber2 = Convert.ToDecimal(Console.ReadLine());

    /*
     == :=
     != <>
     <
     >
     <=
     >=
    */
    //result = 0;
    //int tempInt = 15;

    //if (typedOption == 1)
    //{
    //     var tempInt2 = 15;
    //    result = typedNumber1 + typedNumber2;
    //    Console.WriteLine(tempInt2);
    //}
    //if (typedOption == 2)
    //{
    //    result = typedNumber1 - typedNumber2;
    //    //Console.WriteLine(tempInt); 
    //}
    //if (typedOption == 3)
    //{
    //    result = typedNumber1 * typedNumber2;
    //}
    //if (typedOption == 4)
    //{
    //    result = typedNumber1 / typedNumber2;
    //}
    ////if (typedOption == 5)
    ////{
    ////    result =0;
    ////}
    //nested ifs
    //if (typedOption == 1)
    //{
    //    var tempInt2 = 15;
    //    result = typedNumber1 + typedNumber2;
    //    Console.WriteLine(tempInt2);
    //}
    //else
    //{
    //    var tempInt2 = 15;
    //    if (typedOption == 2)
    //    {
    //        result = typedNumber1 - typedNumber2;
    //        Console.WriteLine(tempInt2);
    //    }
    //    else
    //    {
    //        if (typedOption == 3)
    //        {
    //            result = typedNumber1 * typedNumber2;
    //            Console.WriteLine(tempInt2);
    //        }
    //        else
    //        {
    //            var temp2 = string.Empty;
    //            if (typedOption == 4)
    //            {
    //                result = typedNumber1 / typedNumber2;
    //            }
    //            else
    //            {
    //                Console.WriteLine(tempInt2);
    //                result = 0;
    //                //if (typedOption == 5)
    //                //{
    //                //    result = 0;
    //                //}
    //                //else { 
    //                //    result = 0; 
    //                //}
    //            }
    //        }
    //    }
    //}

    //if (typedOption == 1)
    //{ 
    //    result = typedNumber1 + typedNumber2; 
    //}
    //else if (typedOption == 2)
    //{
    //    result = typedNumber1 - typedNumber2;
    //}
    //else if (typedOption == 3)
    //{
    //    result = typedNumber1 * typedNumber2;
    //}
    //else if (typedOption == 4)
    //{
    //    result = typedNumber1 / typedNumber2;
    //}
    //else
    //{
    //    result = 0; 
    //}

    switch (typedOption)
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
            result = typedNumber1 / typedNumber2;
            break;
        default:
            result = 0;
            break;
    }


    //result = typedNumber1 + typedNumber2;

    Console.WriteLine($"The Result of the operation is:{result}");


}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"you can not divide by zero: {ex.Message}");
    //Console.WriteLine("Closing Db Conection");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"you can not divide by zero: {ex.Message}");
    //Console.WriteLine("Closing Db Conection");
}
catch (Exception ex)
{
    Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    //Console.WriteLine("Closing Db Conection");
}
finally
{
    Console.WriteLine("Closing Db Conection");
}
