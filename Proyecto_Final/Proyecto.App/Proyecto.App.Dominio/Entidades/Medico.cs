using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Proyecto.App.Dominio.Entidades
{
    public class Medico
    {
        [Key]
        [Display(Name = "N_matriculaPro")]
        public int N_matriculaPro {get; set;}       
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto{get;set;}
        [Required]        
               
        [Display(Name = "Consultorio")]
        public string Consultorio {get;set;}
        [Required]        
        [Display(Name = "Especialidad")]
        public string Especialidad {get;set;}
       

        }
        
    }