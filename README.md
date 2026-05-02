# Tarea 3 — Sistema de Gestión de Empleados

**Nombre:** Christopher Duarte  
**Carnet:** C12585  
**Curso:** Lenguajes para Aplicaciones Comerciales  
**Universidad de Costa Rica**

---

## Descripción

Sistema web desarrollado en ASP.NET Core MVC con Entity Framework Core que permite
administrar la nómina de empleados de una empresa consultora. Incluye registro,
edición, búsqueda avanzada, paginación y gestión de estado activo/baja lógica.

---

## Requisitos previos

- Visual Studio 2022 o superior
- .NET 9.0 SDK
- SQL Server o LocalDB

---

## Instrucciones de ejecución

1. Clonar el repositorio:

   git clone https://github.com/Chrisinmas/Tarea3_GestionEmpleados_C12585.git

2. Abrir la solución `Tarea3_GestionEmpleados_C12585.sln` en Visual Studio.

3. Verificar la cadena de conexión en `appsettings.json`:

   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GestionEmpleadosDb;Trusted_Connection=True;MultipleActiveResultSets=true"
   }

4. Ejecutar las migraciones en la Consola del Administrador de Paquetes:

   Update-Database

5. Ejecutar el proyecto con Ctrl + F5 o el botón de inicio en Visual Studio.

6. La aplicación abrirá automáticamente en /Empleados con 10 empleados de prueba
   cargados automáticamente.

---

## Funcionalidad de paginación

La paginación está implementada en el repositorio usando Skip y Take de LINQ.
El sistema muestra 5 empleados por página. La barra de paginación indica la página
actual, el total de páginas y el total de registros encontrados. Los botones
Anterior y Siguiente se deshabilitan automáticamente en los extremos.

El conteo total se calcula con el mismo filtro de búsqueda activo, por lo que la
paginación siempre refleja los resultados filtrados.

---

## Ejemplos de URL con búsqueda

| URL | Resultado esperado |
|-----|-------------------|
| /Empleados | Muestra los primeros 5 empleados. Página 1 de 2. Total: 10 |
| /Empleados?busqueda=TI | Filtra empleados del departamento TI. Total: 3 |
| /Empleados?busqueda=Ana | Filtra empleados cuyo nombre contenga Ana. Total: 1 |
| /Empleados?busqueda=Garcia&pagina=1 | Busca por apellido García, página 1 |
| /Empleados?pagina=2 | Muestra la segunda página sin filtro |

---

## Arquitectura del proyecto

Models/          -> Modelo Empleado con Data Annotations
Data/            -> AppDbContext y SeedData
Repositories/    -> IEmpleadoRepository y EmpleadoRepository
Controllers/     -> EmpleadosController
Views/Empleados/ -> Index, Create, Edit
script sql/      -> Script de creación de base de datos

---

## Commits principales

1. Estructura inicial del proyecto
2. Agrega modelo Empleado con Data Annotations y AppDbContext
3. Implementa IEmpleadoRepository y EmpleadoRepository con búsqueda y paginación
4. Agrega EmpleadosController con Index, Create, Edit y ToggleActivo
5. Agrega vista Index con búsqueda y paginación
6. Agrega vistas Create y Edit con validaciones
7. Agrega SeedData con 10 empleados, script SQL y migración inicial
8. Agrega README completo