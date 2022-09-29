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
    public class DeleteModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Usuario usuario  { get; set; } 

        public DeleteModel()
        {            
            this._appContext = new Repositorios(new Proyecto.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
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

        //se ejecuta al presionar Eliminar en el formulario
        public IActionResult OnPost()
        {
            if(usuario.id > 0)
            {     
               _appContext.DeleteUsuario(usuario.id);           
            }
            return Redirect("List");
        }
    }
}