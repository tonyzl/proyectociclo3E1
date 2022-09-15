using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TransporteBusesApp.Persistencia.AppRepositorios;

namespace TransporteBusesApp.Frontend.Pages
{
    public class FormEstacionesModel : PageModel
    {
        private readonly IRepositorioEstaciones repositorioEstaciones;
        
        [BindProperty]
        public Dominio.Estaciones Estacion {get;set;}

        [TempData]
        public string mensaje_error { get; set; }
        [TempData]
        public string mensaje_guardado { get; set; }
        
        public FormEstacionesModel(IRepositorioEstaciones repositorioEstaciones)
        {
            this.repositorioEstaciones = repositorioEstaciones;
        }

        public void OnGet()
        {
 
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                repositorioEstaciones.Create(Estacion);
                TempData["success"] = "Estacion Creada Correctamente";
                return RedirectToPage("List");
            }
            TempData["error"] = "Error al crear la Estacion";
            return Page();
        }
    }
}