// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Empleados;
Empleado[] arreglo = new Empleado[2];
for (int i = 0; i < arreglo.Length; i++)
{
    Console.WriteLine($"----Empleado {i+1}----");
    arreglo[i] = new Empleado();
    Console.Write("Ingrese nombre: ");
    arreglo[i].Nombre = Console.ReadLine();
    Console.Write("Ingrese apellido: ");
    arreglo[i].Apellido = Console.ReadLine();
    Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
    if (DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null, System.Globalization.DateTimeStyles.None,out DateTime fecha))
    {
        arreglo[i].FechaNac = fecha;
    }else{
        Console.WriteLine("ERROR");
    }
    Console.Write("Estado civil (c: casado, s:soltero): ");
    if (char.TryParse(Console.ReadLine(),out char dato))
    {
        arreglo[i].EstadoCivil = dato;
    }
    Console.Write("Fecha de ingreso (dd/mm/aaaa): ");
        if (DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null, System.Globalization.DateTimeStyles.None,out DateTime fecha2))
    {
        arreglo[i].FechaIng = fecha2;
    }else{
        Console.WriteLine("ERROR");
    }
    Random random2 = new Random();
    arreglo[i].SueldoBasico = random2.Next(300000, 1000000);
    
    Random random = new Random();
    arreglo[i].Cargo = (Cargos)random.Next(0, 5);
}
for (int i = 0; i < arreglo.Length; i++)
{
    Console.WriteLine($"--Empleado nro {i+1}--");
    arreglo[i].mostrar();
    Console.WriteLine("");
}
int auxMayor = 0;
int indice = 0;
for (int a = 0; a < arreglo.Length; a++)
{
    if (arreglo[a].edades() > auxMayor)
    {
        auxMayor = arreglo[a].edades();
        indice = a;
    }
}
Console.WriteLine("");
Console.WriteLine("EMPLEADO MAS VIEJO");
arreglo[indice].mostrar();