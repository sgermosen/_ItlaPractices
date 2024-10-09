{
    int typepOption = 1;
    int chosenContinue = 0;
    string firstTypedNumber;
    //decimal firstTypedNumberConverted;
    //decimal secondTypedNumberConverted;
    decimal total = 0;
    //Array
    decimal[] typedNumbers = new decimal[2];
    List<decimal> typedNumbers2 = new List<decimal>();
    bool wantToContinue = true;

    Console.WriteLine("Esto es una calculadora Básica");

    Console.WriteLine("Digita el numero que represente la operación que deseas realizar");

    Console.WriteLine("1. Suma, \n 2. Resta,  \n 3. Multiplicación,  \n 4. División,  \n 5. Salir");
    try
    {

        typepOption = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite el primer número");
        firstTypedNumber = Console.ReadLine();
        //typedNumbers[0] = Convert.ToDecimal(firstTypedNumber);
        typedNumbers2.Add(Convert.ToDecimal(firstTypedNumber));
        Console.WriteLine("Digite el segundo número");

        //typedNumbers[1] = Convert.ToDecimal(Console.ReadLine());
        typedNumbers2.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("Desea continuar agregando números: 1. Si, 2. No ?");

        chosenContinue = Convert.ToInt32(Console.ReadLine());

        if (chosenContinue == 1 || chosenContinue == 2)
        {
            while (chosenContinue == 1)
            {
                Console.WriteLine("Digite un nuevo número");
                int newDimention = typedNumbers.Length + 1;
                decimal[] oldTypedNumbers = typedNumbers;
                typedNumbers = new decimal[newDimention];

                for (int i = 0; i <= oldTypedNumbers.Length - 1; i++)
                {
                    typedNumbers[i] = oldTypedNumbers[i];
                }
                typedNumbers[newDimention - 1] = Convert.ToDecimal(Console.ReadLine());
                typedNumbers2.Add(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine("Desea continuar agregando números: 1. Si, 2. No ?");

                chosenContinue = Convert.ToInt32(Console.ReadLine());

            } 
        }
        switch (typepOption)
        {
            case 1:
                {
                    for (int i = 0; i < typedNumbers.Length; i++)
                    {
                        total = total + typedNumbers[i];
                        // total += typedNumbers[i];
                    }
                    for (int i = 0; i < typedNumbers2.Count; i++)
                    {
                        total = total + typedNumbers2[i];
                        // total += typedNumbers[i];
                    }
                    foreach (var item in typedNumbers)
                    {
                        total = total + item;
                    }
                    foreach (var item in typedNumbers2)
                    {
                        total = total + item;
                    }

                }
                break;
            case 2:
                {
                    for (int i = 0; i < typedNumbers.Length; i++)
                    {
                        total = total - typedNumbers[i];
                    }
                }
                break;
            case 3:
                {
                    for (int i = 0; i < typedNumbers.Length; i++)
                    {
                        total = total * typedNumbers[i];
                    }
                }
                break;
            case 4:
                {
                    for (int i = 0; i < typedNumbers.Length; i++)
                    {
                        total = total / typedNumbers[i];
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
        //throw;
        Console.WriteLine($"Error de formato: {ex.Message}");

    }
    catch (Exception ex)
    {
        //throw;
        Console.WriteLine($"Error: {ex.Message}");

    }
    finally
    {
        Console.WriteLine("cerrando la conexion");
    }
}