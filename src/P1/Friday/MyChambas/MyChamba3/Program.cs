

//decimal[] typedNumbers = new decimal[5];
//decimal[] typedNumbers = new decimal[2];

List<decimal> typedNumbers = new List<decimal>();
//typedNumbers.Add(0);
//typedNumbers.Add(0);
//typedNumbers[0] = 9544565.8m;

//typedNumbers[1] = 56.8m;
//typedNumbers[2] = 69.8m;
//typedNumbers[3] = 4575;
//typedNumbers[4] = 546542;

//decimal[] typedNumbers2 = new decimal[] { 14, 58.5m, 6, 89.2m, 7, 96 };
//decimal[] typedNumbers3 = new decimal[5] { 14, 58.5m, 6, 89.2m, 7, 96 };
//decimal[] typedNumbers4 = { 14, 58.5m, 6, 89.2m, 7, 96 };


decimal result = 0;
short typedOption = 1;
//string wantToContinueTipingMoreNumberForOperation = string.Empty;
short wantToContinueTipingMoreNumberForOperation = 1;

bool running = true;

do
{

    Console.WriteLine("This is the best calculator");
    Console.WriteLine("Please Type the option number than you want");
    Console.WriteLine("1. Sum, 2. Substract, 3. Multiplication, 4. Division, 5. Exit");

    try
    {
        typedOption = short.Parse(Console.ReadLine());

        if (typedOption != 5)
        {
            Console.WriteLine("Please Type the first number");
            //decimal.TryParse(Console.ReadLine(), out typedNumbers[0]);
            //var tempTypedValue = decimal.Parse(Console.ReadLine());
            //decimal.TryParse(Console.ReadLine(), out tempTypedValue);
            //typedNumbers[0] = tempTypedValue;

            //typedNumbers[0] = decimal.Parse(Console.ReadLine());

            typedNumbers.Add(decimal.Parse(Console.ReadLine()));


            Console.WriteLine("Please Type the second number");
            //typedNumbers[1] = decimal.Parse(Console.ReadLine());
            typedNumbers.Add(decimal.Parse(Console.ReadLine()));
            //Console.WriteLine("Do you want to continue tipying more numbers for the operation? Yes/No ");
            // wantToContinueTipingMoreNumberForOperation = Console.ReadLine();

            //var index = 2;
            while (wantToContinueTipingMoreNumberForOperation == 1)
            {
                Console.WriteLine("Do you want to continue tipying more numbers for the operation? 1.Yes 2. No (Please type only the number) ");
                wantToContinueTipingMoreNumberForOperation = short.Parse(Console.ReadLine());

                if (wantToContinueTipingMoreNumberForOperation == 1)
                {
                    Console.WriteLine("Please Type the a new number");
                    //typedNumbers[index] = decimal.Parse(Console.ReadLine());
                    //typedNumbers[typedNumbers.Length] = decimal.Parse(Console.ReadLine());

                    //index++;
                    //++index;
                    //index = index + 1;
                    //index += 1;

                    //var oldTypedNumbers = typedNumbers;

                    //typedNumbers = new decimal[typedNumbers.Length + 1];

                    //for (int i = 0; i < oldTypedNumbers.Length; i++)
                    //{
                    //    typedNumbers[i] = oldTypedNumbers[i]; 
                    //}

                    //typedNumbers[typedNumbers.Length - 1] = decimal.Parse(Console.ReadLine());

                    //var newTypeValue = decimal.Parse(Console.ReadLine());

                    //decimal[] tempArray = new decimal[typedNumbers.Length - 1];
                    //typedNumbers.CopyTo(tempArray, 0);

                    //typedNumbers.Append(newTypeValue);

                    //Array.Resize(ref typedNumbers, typedNumbers.Length + 1);
                    //typedNumbers[typedNumbers.Length] = newTypeValue;

                    //var newTypeValue = decimal.Parse(Console.ReadLine());
                    //typedNumbers.Add(0);
                    //typedNumbers[typedNumbers.Count - 1] = newTypeValue;
                    // typedNumbers.Add(newTypeValue);
                    typedNumbers.Add(decimal.Parse(Console.ReadLine()));



                }
            }



            //// if (wantToContinueTipingMoreNumberForOperation == "y" || wantToContinueTipingMoreNumberForOperation == "Y" || wantToContinueTipingMoreNumberForOperation == "yes" || wantToContinueTipingMoreNumberForOperation == "YES")
            //// if (wantToContinueTipingMoreNumberForOperation.ToLower() == "y" || wantToContinueTipingMoreNumberForOperation.ToLower() == "yes")
            //if (wantToContinueTipingMoreNumberForOperation.ToLower().Substring(0, 1) == "y")
            ////if (wantToContinueTipingMoreNumberForOperation.Substring(0, 1).Equals("y", StringComparison.OrdinalIgnoreCase))
            ////   if (wantToContinueTipingMoreNumberForOperation.ToUpper() == "Y"   || wantToContinueTipingMoreNumberForOperation == "yes" || wantToContinueTipingMoreNumberForOperation == "YES")
            ////if (wantToContinueTipingMoreNumberForOperation == 1)
            //{

            //}
            ////else if (wantToContinueTipingMoreNumberForOperation == 2)
            ////{
            ////    Console.WriteLine("we are going to continue");
            ////}
            ////else if (wantToContinueTipingMoreNumberForOperation < 1 && wantToContinueTipingMoreNumberForOperation > 2)
            ////{
            ////    // and &&     or ||     not  !


            ////    // and
            ////    // v && v = V
            ////    // v && f = F
            ////    // f && v = F
            ////    // f && f = F
            ////    // 

            ////    // or
            ////    // v || v = V
            ////    // v || f = V
            ////    // f || v = V
            ////    // f || f = F
            ////    //

            ////    //not 
            ////    //!(v) = f
            ////    //!(f) = v

            ////    // v && v   && f && v && f || v || f || v && v
            ////    // v        && f && v && f || v || f || v && v
            ////    // f             && v && f || v || f || v && v
            ////    // f                  && f || v || f || v && v
            ////    // f                       || v || f || v && v
            ////    // v                            || f || v && v
            ////    // v                                 || v && v
            ////    // v                                      && v
            ////    // v

            ////    Console.WriteLine("I told you than type 1 or 2, no more");
            ////}
            //else
            //{

        }
        switch (typedOption)
        {
            case 1:
                {
                    //result = typedNumbers[0] + typedNumbers[1];
                    //  for (int i = 0; i < typedNumbers.Length; i++)
                    for (int i = 0; i < typedNumbers.Count; i++)
                    {
                        result += typedNumbers[i];
                    }
                    break;
                }
            case 2:
                foreach (var number in typedNumbers)
                {
                    result += number;
                }
                //var tempInt = 5;
                //result = typedNumbers[0] - typedNumbers[1];
                //Console.WriteLine(tempInt.ToString());
                break;
            case 3:
                result = typedNumbers[0] * typedNumbers[1];
                break;
            case 4:
                result = typedNumbers[0] / typedNumbers[1];
                break;
            default:
                running = false;
                result = 0;
                break;
        }

        Console.WriteLine($"The Result of the operation is:{result}");
        //}

         


    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"you can not divide by zero");
        Console.WriteLine("Closing Db Conection");
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

} while (running);

Console.WriteLine("Go well");
