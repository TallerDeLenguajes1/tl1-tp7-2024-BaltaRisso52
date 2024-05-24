// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Console.WriteLine("Hello, World!");
bool continuar = true;
var prueba = new Calculadora();

while (continuar)
{

    Console.WriteLine($"Actual Resultado: {prueba.Resultado}");
    Console.WriteLine("-----MENU DE CALCULADORA-----");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir (nro distinto a 0)");
    Console.WriteLine("5.Limpiar");
    Console.WriteLine("6.Salir");
    Console.Write("Ingrese la opcion: ");
    string opcion = Console.ReadLine();

    if (int.TryParse(opcion, out int opc) && opc < 7 && opc > 0)
    {
        if (opc != 5 && opc != 6)
        {
            Console.Write("Ingrese el numero: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                switch (opc)
                {
                    case 1:
                        prueba.Sumar(numero);
                        Console.WriteLine($"Despues de sumar queda: {prueba.Resultado} ");
                        break;

                    case 2:
                        prueba.Restar(numero);
                        Console.WriteLine($"Despues de restar queda: {prueba.Resultado} ");
                        break;

                    case 3:
                        prueba.Multiplicar(numero);
                        Console.WriteLine($"Despues de multiplicar queda: {prueba.Resultado} ");
                        break;

                    case 4:
                        prueba.Dividir(numero);
                        if (numero != 0)
                        {
                            Console.WriteLine($"Despues de dividir queda: {prueba.Resultado} ");
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        else
        {
            switch (opc)
            {
                case 5:
                    prueba.Limpiar();
                    Console.WriteLine($"Despues de limpiar queda: {prueba.Resultado} ");
                    break;

                case 6:
                    continuar = false;
                    break;
                default:
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("ERROR");
    }
}

Console.WriteLine($"Resultado Final: {prueba.Resultado}");





