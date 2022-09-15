using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TransporteBusesApp.Persistencia.AppRepositorios;
using TransporteBusesApp.Dominio;
 
namespace TransporteBusesApp.Frontend.Pages
{
    public class EditEstacionModel : PageModel
    {
       private readonly IRepositorioEstaciones repositorioEstaciones;
       [BindProperty]
       public Dominio.Estaciones Estacion {get;set;}
       
       [TempData]
        public string mensaje_error { get; set; }
        [TempData]
        public string mensaje_guardado { get; set; }
 
        public EditEstacionModel(IRepositorioEstaciones repositorioEstaciones)
       {
            this.repositorioEstaciones=repositorioEstaciones;
       }
 
        public IActionResult OnGet(int estacionId)
        {
            Estacion=repositorioEstaciones.GetWithId(estacionId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                TempData["error"] = "Error al Editar la Estacion";
                return Page();
            }
            if(Estacion.id>0)
            {
             Estacion = repositorioEstaciones.Update(Estacion);
            }
            TempData["success"] = "Estacion editada correctamente";
            return RedirectToPage("./List");
        }

    }
}