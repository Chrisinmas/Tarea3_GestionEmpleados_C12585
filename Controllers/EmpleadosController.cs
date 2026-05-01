using Microsoft.AspNetCore.Mvc;
using Tarea3_GestionEmpleados_C12585.Models;
using Tarea3_GestionEmpleados_C12585.Repositories;

namespace Tarea3_GestionEmpleados_C12585.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoRepository _repo;
        private const int TamanoPagina = 5;

        public EmpleadosController(IEmpleadoRepository repo)
        {
            _repo = repo;
        }

        // GET: /Empleados
        public IActionResult Index(string? busqueda, int pagina = 1)
        {
            var total = _repo.ContarTotal(busqueda);
            var empleados = _repo.ObtenerPaginado(pagina, TamanoPagina, busqueda);
            var totalPaginas = (int)Math.Ceiling((double)total / TamanoPagina);

            ViewBag.Busqueda = busqueda;
            ViewBag.PaginaActual = pagina;
            ViewBag.TotalPaginas = totalPaginas;
            ViewBag.TotalRegistros = total;

            return View(empleados);
        }

        // GET: /Empleados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Empleados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                empleado.FechaIngreso = DateTime.Now;
                _repo.Agregar(empleado);
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: /Empleados/Edit/5
        public IActionResult Edit(int id)
        {
            var empleado = _repo.ObtenerPorId(id);
            if (empleado == null) return NotFound();
            return View(empleado);
        }

        // POST: /Empleados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Empleado empleado)
        {
            if (id != empleado.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _repo.Actualizar(empleado);
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // POST: /Empleados/ToggleActivo/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ToggleActivo(int id)
        {
            var empleado = _repo.ObtenerPorId(id);
            if (empleado == null) return NotFound();

            empleado.Activo = !empleado.Activo;
            _repo.Actualizar(empleado);

            return RedirectToAction(nameof(Index));
        }
    }
}