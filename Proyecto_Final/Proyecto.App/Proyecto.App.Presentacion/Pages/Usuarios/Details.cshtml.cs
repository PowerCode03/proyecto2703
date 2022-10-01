using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyecto.App.Dominio.Entidades;
using Proyecto.App.Persistencia.AppRepositorios;
using Proyecto.App.Persistencia;

namespace Proyecto.App.Presentacion.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Usuario usuario { get; set; } 

        public DetailsModel()
        {            
            this._appContext = new Repositorios(new Proyecto.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? usuarioId)
        {
            if (usuarioId.HasValue)
            {
                usuario = _appContext.GetUsuario(usuarioId.Value);
            }
            if (usuario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}