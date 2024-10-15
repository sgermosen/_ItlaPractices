{
    int typepOption = 1;
    int chosenContinue = 0;
    decimal total = 0;
    List<decimal> typedNumbers2 = new List<decimal>();
    List<decimal> typedNumbers1 = new List<decimal>();

    Console.WriteLine("Esto es una calculadora Básica");

    Console.WriteLine("Digita el numero que represente la operación que deseas realizar");

    Console.WriteLine("1. Suma, \n 2. Resta,  \n 3. Multiplicación,  \n 4. División,  \n 5. Salir");
    try
    {

        typepOption = int.Parse(Console.ReadLine());
         
        CaptureValueFromUser(ref typedNumbers2);

        CaptureValueFromUser(ref typedNumbers2);
         
        Console.WriteLine("Desea continuar agregando números: 1. Si, 2. No ?"); 
        chosenContinue = Convert.ToInt32(Console.ReadLine());

        if (chosenContinue == 1 || chosenContinue == 2)
        {
            while (chosenContinue == 1)
            {
                CaptureValueFromUser(ref typedNumbers2);

                Console.WriteLine("Desea continuar agregando números: 1. Si, 2. No ?");

                chosenContinue = Convert.ToInt32(Console.ReadLine());
            }
        }
        switch (typepOption)
        {
            case 1:
                {  
                    foreach (var item in typedNumbers2)
                    {
                        SumByRef(ref total, item);
                        total = Sum(total, item);
                        total = MakeOperation(total, item, typepOption);
                    } 
                }
                break;
            case 2:
                {
                    for (int i = 0; i < typedNumbers2.Count; i++)
                    {
                        //total = total - typedNumbers2[i];
                        total = MakeOperation(total, typedNumbers2[i], typepOption);

                    }
                }
                break;
            case 3:
                {
                    for (int i = 0; i < typedNumbers2.Count; i++)
                    {
                      //  total = total * typedNumbers2[i];
                        total = MakeOperation(total, typedNumbers2[i], typepOption);

                    }
                }
                break;
            case 4:
                {
                    for (int i = 0; i < typedNumbers2.Count; i++)
                    {
                      //  total = total / typedNumbers2[i];
                        total = MakeOperation(total, typedNumbers2[i], typepOption);

                    }
                }
                break;
            default:
                total = 0;
                break;
        }
        Console.WriteLine($"Tu resultado es: {total}");

    }

    catch (FormatException ex)
    {
        Console.WriteLine($"Error de formato: {ex.Message}");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");

    }
    finally
    {
        Console.WriteLine("cerrando la conexion");
    }



    static decimal MakeOperation(decimal originalValue, decimal newValue, int option)
    {
        switch (option)
        {
            case 1:
                 return originalValue += newValue;  
            case 2:
                return originalValue -= newValue; 
            case 3:
                return originalValue *= newValue; 
            case 4:
                return originalValue /= newValue;  
        }
        return originalValue;
    }

    static void CaptureValueFromUser(ref List<decimal> value)
    {
        if (!value.Any())
        {
            Console.WriteLine("Digite un primer valor núumerico");
        }
        else
        {
            Console.WriteLine("Digite otro valor núumerico");
        }
        value.Add(Convert.ToDecimal(Console.ReadLine()));
    }
     
    static decimal Sum(decimal originalValue, decimal addedValue)
    { 
        originalValue += addedValue;
        return originalValue;
    }

    static void SumByRef(ref decimal originalValue, decimal addedValue)
    { 
        originalValue += addedValue;
    }
}

