#nullable disable
Console.Clear();

Boolean Loop = true;
Random rnd = new Random();



while (Loop)
{
    Console.WriteLine("simulador de tirar de los dados");
    Console.WriteLine("1. Tirarlo uno vez");
    Console.WriteLine("2. Tirarlo cinco veces");
    Console.WriteLine("3. Tirarlo 'x' veces");
    Console.WriteLine("4. Tirar hasta 'Snake eyes'");
    Console.WriteLine("5. Abandonar");

    Int32 Dido;
    Int32 Dido2;
    Int32 Sum;
    Int32 I;


    Int32 Opcion = Convert.ToInt32(Console.ReadLine());

    if (Opcion == 1)
    {

        Dido = rnd.Next(1, 6);
        Dido2 = rnd.Next(1, 6);

        Sum = Dido + Dido2;
        Console.WriteLine($"{Dido},{Dido2} (Sum: {Sum})");
    }
    else if (Opcion == 2)
    {
        for (I = 0; I < 5; I++)
        {
            Dido = rnd.Next(1, 6);
            Dido2 = rnd.Next(1, 6);
            Sum = Dido + Dido2;

            Sum = Dido + Dido2;
            Console.WriteLine($"{Dido},{Dido2} (Sum: {Sum})");
        };
    }
    else if (Opcion == 3)
    {
        Console.WriteLine("Cuanto Veces");
        Int32 AAA = Convert.ToInt32(Console.ReadLine());


        for (I = 0; I < AAA; I++)
        {
            Dido = rnd.Next(1, 6);
            Dido2 = rnd.Next(1, 6);
            Sum = Dido + Dido2;

            Sum = Dido + Dido2;
            Console.WriteLine($"{Dido},{Dido2} (Sum: {Sum})");
        };
        // Console.WriteLine($"{Dido},{Dido2}");
    }
    else if (Opcion == 4) {
        bool BBB = true;
        Dido = rnd.Next(1, 6);
        Dido2 = rnd.Next(1, 6);
        Sum = Dido + Dido2;
        int rolls = 0;

        while (BBB) {
            Dido = rnd.Next(1, 6);
            Dido2 = rnd.Next(1, 6);
            Sum = Dido + Dido2;

            Console.WriteLine($"{Dido},{Dido2} (Sum: {Sum})");
            if (Sum == 2) {
                BBB = false;
            } else {
                rolls++;
            }
        };
         Console.WriteLine($"{rolls} tirars");
    }
    else if (Opcion == 5)
    {
        Loop = false;
    };

};
