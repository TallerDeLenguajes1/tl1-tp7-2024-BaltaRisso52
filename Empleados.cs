namespace Empleados
{
    enum Cargos
    {
        auxiliar,
        administrativo,
        ingeniero,
        especialista,
        investigador
    }
    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private char estadoCivil;
        private DateTime fechaIng;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        internal Cargos Cargo { get => cargo; set => cargo = value; }

        public int antiguedad()
        {
            TimeSpan antig = DateTime.Now - fechaIng;
            int anioAnt = antig.Days / 365;
            return anioAnt;
        }
        public int edades()
        {
            TimeSpan edad = DateTime.Now - fechaNac;
            int resultado = edad.Days / 365;
            return resultado;
        }
        public int jubilarse()
        {
            int jubilacion = 65 - edades();
            return jubilacion;
        }
        public double salario()
        {
            double auxAntiguedad = 0;
            if (antiguedad() < 21)
            {
                auxAntiguedad = antiguedad();
            }
            else
            {
                auxAntiguedad = 25;
            }
            double auxCargo = 0;
            if (Cargo == Cargos.ingeniero || Cargo == Cargos.especialista)
            {
                auxCargo = 50;
            }
            double auxEstado = 0;
            if (estadoCivil == 'c' || estadoCivil == 'C')
            {
                auxEstado = 150000;
            }
            double salarios = sueldoBasico + (sueldoBasico * (auxAntiguedad / 100) + (sueldoBasico * (auxCargo / 100)) + auxEstado);
            return salarios;
        }
        public void mostrar()
        {
            Console.Write("Nombre: ");
            Console.Write(nombre);
            Console.WriteLine("");
            Console.Write("Apellido: ");
            Console.Write(apellido);
            Console.WriteLine("");
            Console.Write("Fecha de nacimiento: ");
            Console.Write(fechaNac.ToShortDateString());
            Console.WriteLine("");
            Console.Write("Estado civil: ");
            if (estadoCivil == 'c' || estadoCivil == 'C')
            {
                Console.Write("Casado");
            }
            else
            {
                Console.Write("Soltero");
            }
            Console.WriteLine("");
            Console.Write("Fecha de ingreso: ");
            Console.Write(fechaIng.ToShortDateString());
            Console.WriteLine("");
            Console.Write("Sueldo basico: ");
            Console.Write(sueldoBasico);
            Console.WriteLine("");
            Console.Write("Cargo: ");
            Console.Write(cargo);
            Console.WriteLine("");
            Console.Write("Salario: ");
            Console.Write(salario());
            Console.WriteLine("");
        }
    }
}