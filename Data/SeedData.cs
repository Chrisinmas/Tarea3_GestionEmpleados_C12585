using Tarea3_GestionEmpleados_C12585.Models;

namespace Tarea3_GestionEmpleados_C12585.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Empleados.Any()) return;

            context.Empleados.AddRange(
                new Empleado { Nombre = "Ana", Apellidos = "García López", Departamento = "TI", Salario = 850000, FechaIngreso = new DateTime(2020, 3, 15), Activo = true },
                new Empleado { Nombre = "Carlos", Apellidos = "Rodríguez Mora", Departamento = "TI", Salario = 920000, FechaIngreso = new DateTime(2019, 7, 1), Activo = true },
                new Empleado { Nombre = "María", Apellidos = "Fernández Castro", Departamento = "TI", Salario = 780000, FechaIngreso = new DateTime(2021, 1, 10), Activo = true },
                new Empleado { Nombre = "Luis", Apellidos = "Martínez Pérez", Departamento = "Recursos Humanos", Salario = 700000, FechaIngreso = new DateTime(2018, 5, 20), Activo = true },
                new Empleado { Nombre = "Sofía", Apellidos = "Vargas Jiménez", Departamento = "Recursos Humanos", Salario = 650000, FechaIngreso = new DateTime(2022, 2, 28), Activo = false },
                new Empleado { Nombre = "Pedro", Apellidos = "Solís Campos", Departamento = "Finanzas", Salario = 1100000, FechaIngreso = new DateTime(2017, 9, 5), Activo = true },
                new Empleado { Nombre = "Laura", Apellidos = "Núñez Bravo", Departamento = "Finanzas", Salario = 980000, FechaIngreso = new DateTime(2020, 11, 3), Activo = true },
                new Empleado { Nombre = "Diego", Apellidos = "Arias Quesada", Departamento = "Ventas", Salario = 600000, FechaIngreso = new DateTime(2023, 4, 17), Activo = true },
                new Empleado { Nombre = "Valeria", Apellidos = "Mora Sandoval", Departamento = "Ventas", Salario = 580000, FechaIngreso = new DateTime(2023, 6, 1), Activo = false },
                new Empleado { Nombre = "Andrés", Apellidos = "Blanco Rojas", Departamento = "Operaciones", Salario = 750000, FechaIngreso = new DateTime(2021, 8, 22), Activo = true }
            );

            context.SaveChanges();
        }
    }
}