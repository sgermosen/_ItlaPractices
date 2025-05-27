decimal typedNumber1;
decimal typedNumber2;

decimal result;
//string capturedValue;
int typedOption = 1;
Console.WriteLine("This is the best calculator");

Console.WriteLine("Please Type the option number than you want");
Console.WriteLine("1. Sum, 2. Substract, 3. Multiplication, 4. Division, 5. Exit");
Console.WriteLine("---------------------------------------");
Console.WriteLine("1. Sum");
Console.WriteLine("2. Substract");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.WriteLine("---------------------------------------");
Console.WriteLine("1. Sum, \n2. Substract,  \n3. Multiplication,  \n4. Division,  \n5. Exit");

//try
//{

typedOption = Convert.ToInt32(Console.ReadLine());

//var capturedValue = Console.ReadLine();
//typedOption = Convert.ToInt32(capturedValue);

try
{
    Console.WriteLine("Please Type the first number");
    typedNumber1 = Convert.ToDecimal(Console.ReadLine());
}
catch (Exception)
{

    throw;
}

//var capturedValue = Console.ReadLine();
//typedNumber1 = Convert.ToDecimal(capturedValue);
//typedNumber1 = decimal.Parse(capturedValue);

Console.WriteLine("Please Type the second number");
typedNumber2 = decimal.Parse(Console.ReadLine());

/* comparison operators (They are questions basically than ask if A element is equals, distinct, etc, about the B Element)
 == := equals to
 != <> distinct from
 <   less than
 >  greater than
 <= less than or equals to
 >= greater than or equals to 
*/

//  int tempInt =0;
//tempInt = 15;
//control structures, blocks 

//ifs and more ifs

//if (typedOption == 1)
//{
//    //var tempInt = 15;
//    // int tempInt = 15;
//    //  tempInt = 15;
//    result = typedNumber1 + typedNumber2;
//    // Console.WriteLine(tempInt);
//    // typedNumber1 = 0;
//}
//if (typedOption == 2)
//{
//    //  int tempInt = 15;
//    result = typedNumber1 - typedNumber2;
//    //  Console.WriteLine(tempInt);
//}
//if (typedOption == 3)
//{
//    result = typedNumber1 * typedNumber2;
//}
//if (typedOption == 4)
//{
//    result = typedNumber1 / typedNumber2;
//}
//if (typedOption == 5)
//{
//    result = 0;
//}

//nested ifs (if - else)

//if (typedOption == 1)
//{
//    var tempInt2 = 15;
//    result = typedNumber1 + typedNumber2;
//    Console.WriteLine(tempInt2);
//}
//else
//{
//    //tempInt2 = 15;
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
//            if (typedOption == 4)
//            {
//                result = typedNumber1 / typedNumber2;
//            }
//            else
//            {
//                //  Console.WriteLine(tempInt2);
//                result = 0;
//                //if (typedOption == 5)
//                //{
//                //    result = 0;
//                //}
//                //else
//                //{
//                //    //Console.WriteLine("Son of the playa, put a number from 1 to 5");
//                //    result = 0;
//                //}
//            }
//        }
//    }
//}

//if - else if - else 

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

//switch (typedOption)
//{
//    case 1:
//        {
//            result = typedNumber1 + typedNumber2;
//            break;
//        }
//    case 2:
//        result = typedNumber1 - typedNumber2;
//        break;
//    case 3:
//        result = typedNumber1 * typedNumber2;
//        break;
//    case 4:
//        result = typedNumber1 / typedNumber2;
//        break;
//    default:
//        result = 0;
//        break;
//}
result = 0;
Console.WriteLine($"The Result of the operation is:{result}");


//}
//catch (Exception ex)
//{
//    Console.WriteLine($"You need to choose a correct option: {ex.Message}");
//    //Console.WriteLine("Closing Db Conection");
//}
//catch (ArithmeticException ex)
//{
//    Console.WriteLine($"you can not divide by zero: {ex.Message}"); 
//}

//catch (DivideByZeroException ex)
//{
//    // Console.WriteLine($"you can not divide by zero: {ex.Message}");
//    Console.WriteLine($"you can not divide by zero");
//    //   Console.WriteLine("Closing Db Conection");
//}
//catch (ArithmeticException ex)
//{
//    Console.WriteLine($"An arimethic exception has occurs");
//    // Console.WriteLine("Closing Db Conection");
//}
//catch (Exception ex)
//{
//    if (ex.Message.Contains("Input string was not in a correct format"))
//    {
//        Console.WriteLine($"You need to type a number");
//    }
//    else
//    {
//        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
//    }
//    //  Console.WriteLine("Closing Db Conection");

//}
////finally
////{
////    Console.WriteLine("Closing Db Conection");
////}
