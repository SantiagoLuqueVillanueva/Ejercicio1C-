using System;

class Program
{
    static void Main()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();
        Ejercicio6();
        Ejercicio7();
        Ejercicio8();
        Ejercicio9();
        Ejercicio10();
    }

    // EJERCICIO 1
    static void Ejercicio1()
    {
        Console.WriteLine("=== EJERCICIO 1 ===");

        Console.Write("Introduce el primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"La suma es {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
        Console.WriteLine($"La división es: {numero1 / numero2}");
        Console.WriteLine($"El módulo es: {numero1 % numero2}");
        Console.WriteLine();
    }

    // EJERCICIO 2
    static void Ejercicio2()
    {
        Console.WriteLine("=== EJERCICIO 2 ===");

        const double PRECIO_HAMBURGUESA = 4.50;
        const double PRECIO_PAPAS = 2.25;
        const double PRECIO_BEBIDA = 1.35;

        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de papas: ");
        int papas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de bebidas: ");
        int bebidas = Convert.ToInt32(Console.ReadLine());

        double totalBar = hamburguesas * PRECIO_HAMBURGUESA + papas * PRECIO_PAPAS + bebidas * PRECIO_BEBIDA;
        Console.WriteLine($"Cantidad a pagar: {totalBar}");
        Console.WriteLine();
    }

    // EJERCICIO 3
    static void Ejercicio3()
    {
        Console.WriteLine("=== EJERCICIO 3 ===");

        Console.Write("Introduce un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        double otroNumero = 10;

        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
        Console.WriteLine($"Seno: {Math.Sin(numero)}");
        Console.WriteLine($"Coseno: {Math.Cos(numero)}");
        Console.WriteLine($"Número máximo entre {numero} y {otroNumero}: {Math.Max(numero, otroNumero)}");
        Console.WriteLine($"Número mínimo entre {numero} y {otroNumero}: {Math.Min(numero, otroNumero)}");
        Console.WriteLine();
    }

    // EJERCICIO 4
    static void Ejercicio4()
    {
        Console.WriteLine("=== EJERCICIO 4 ===");

        Console.Write("Introduce el valor de un lado del cuadrado: ");
        double lado = Convert.ToDouble(Console.ReadLine());
        double perimetro = lado * 4;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
        Console.WriteLine();
    }

    // EJERCICIO 5
    static void Ejercicio5()
    {
        Console.WriteLine("=== EJERCICIO 5 ===");

        Console.Write("Introduce el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el cuarto número: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"La suma de los dos primeros es: {n1 + n2}");
        Console.WriteLine($"El producto del tercero y el cuarto es: {n3 * n4}");
        Console.WriteLine();
    }

    // EJERCICIO 6
    static void Ejercicio6()
    {
        Console.WriteLine("=== EJERCICIO 6 ===");

        Console.Write("Introduce el primer valor: ");
        double v1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo valor: ");
        double v2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el tercer valor: ");
        double v3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el cuarto valor: ");
        double v4 = Convert.ToDouble(Console.ReadLine());

        double suma = v1 + v2 + v3 + v4;
        double promedio = suma / 4;
        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El promedio es: {promedio}");
        Console.WriteLine();
    }

    // EJERCICIO 7
    static void Ejercicio7()
    {
        Console.WriteLine("=== EJERCICIO 7 ===");

        Console.Write("Introduce el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la cantidad que lleva el cliente: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double costeTotal = precio * cantidad;
        Console.WriteLine($"El coste total es: {costeTotal}");
        Console.WriteLine();
    }

    // EJERCICIO 8
    static void Ejercicio8()
    {
        Console.WriteLine("=== EJERCICIO 8 ===");

        Console.Write("Nota del primer parcial: ");
        double parcial1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota del segundo parcial: ");
        double parcial2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota del examen: ");
        double examen = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota del trabajo final: ");
        double trabajo = Convert.ToDouble(Console.ReadLine());

        double promedioParciales = (parcial1 + parcial2) / 2;
        double notaFinal = promedioParciales * 0.5 + examen * 0.3 + trabajo * 0.2;
        Console.WriteLine($"Tu nota final es: {notaFinal}");
        Console.WriteLine();
    }

    // EJERCICIO 9
    static void Ejercicio9()
    {
        Console.WriteLine("=== EJERCICIO 9 ===");

        Console.Write("Cantidad que aporta el socio 1: ");
        double aporte1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cantidad que aporta el socio 2: ");
        double aporte2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cantidad que aporta el socio 3: ");
        double aporte3 = Convert.ToDouble(Console.ReadLine());

        double totalAportado = aporte1 + aporte2 + aporte3;
        double porcentaje1 = aporte1 * 100 / totalAportado;
        double porcentaje2 = aporte2 * 100 / totalAportado;
        double porcentaje3 = aporte3 * 100 / totalAportado;

        Console.WriteLine($"El porcentaje del socio 1 es {porcentaje1}%, del socio 2 es {porcentaje2}% y del socio 3 es {porcentaje3}%");
        Console.WriteLine();
    }

    // EJERCICIO 10
    static void Ejercicio10()
    {
        Console.WriteLine("=== EJERCICIO 10 ===");

        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        bool empiezaPorWww = texto.StartsWith("www");
        Console.WriteLine(empiezaPorWww);
    }
}