using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Nicolas", "Arroyo", new DateTime(2003, 8, 15), 'S',
                            new DateTime(2022, 3, 1), 850000, Cargos.Ingeniero);

empleados[1] = new Empleado("Fernando", "Zelada", new DateTime(1969, 5, 12), 'C',
                            new DateTime(1985, 7, 1), 550000, Cargos.Administrativo);

empleados[2] = new Empleado("Raul", "Rivas", new DateTime(1995, 2, 18), 'C',
                            new DateTime(2015, 4, 20), 610000, Cargos.Especialista);

// Mostrar datos de todos
Console.WriteLine("<<<<<__ Empleados Registrados __>>>>>\n");
foreach (var emple in empleados)
{
    emple.MostrarDatos();
}

//totalidad de los salarios
double totalSalarios = 0;

foreach (var emple in empleados)
{
    totalSalarios += emple.CalcularSalario();
}

Console.WriteLine($"\nMonto total de los salarios: ${totalSalarios}\n\n");

// mostrar proximo a jubilarse
Empleado ProxJubilado = empleados[0];
    foreach (var emple in empleados)
        {
            if (emple.AniosParaJubilarse() < ProxJubilado.AniosParaJubilarse())
            {
                ProxJubilado = emple;
            }
        }

Console.WriteLine("==> Empleado más próximo a jubilarse <==\n");
ProxJubilado.MostrarDatos();