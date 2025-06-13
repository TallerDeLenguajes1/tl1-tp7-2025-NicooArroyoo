namespace Empleado
{
    public class Empleado
    {
        public string Nombre;
        public string Apellido;
        public datetime FechaDeNacimiento;
        public char EstadoCivil;
        public datetime FechaDeIngreso;
        public double SueldoBasico;
        public cargos Cargo;
    }

    enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

}