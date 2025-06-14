namespace EspacioEmpleado
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        private string Nombre;
        private string Apellido;
        private DateTime FechaDeNacimiento;
        private char EstadoCivil;
        private DateTime FechaDeIngreso;
        private double SueldoBasico;
        private Cargos Cargo;

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil,
                        DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaDeIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }

        public int CalcularEdad()
        {
            int edad = DateTime.Today.Year - FechaDeNacimiento.Year;
            if (DateTime.Today < FechaDeNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        public int CalcularAntiguedad()
        {
            int antiguedad = DateTime.Today.Year - FechaDeIngreso.Year;
            if (DateTime.Today < FechaDeIngreso.AddYears(antiguedad))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int AniosParaJubilarse()
        {
            return 65 - CalcularEdad();
        }

        public double CalcularSalario()
        {
            int antiguedad = CalcularAntiguedad();
            double adicional;

            if (antiguedad <= 20)
                adicional = SueldoBasico * (antiguedad * 0.01);
            else
                adicional = SueldoBasico * 0.25;

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                adicional *= 1.5;

            if (EstadoCivil == 'C') // Casado
                adicional += 150000;

            return SueldoBasico + adicional;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Edad: {CalcularEdad()} años");
            Console.WriteLine($"Antigüedad: {CalcularAntiguedad()} años");
            Console.WriteLine($"Años para jubilarse: {AniosParaJubilarse()}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: ${CalcularSalario():N2}");
            Console.WriteLine("\n");

        }

    }
}
