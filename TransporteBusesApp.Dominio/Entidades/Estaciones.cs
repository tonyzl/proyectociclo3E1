using System;
using System.ComponentModel.DataAnnotations;

namespace TransporteBusesApp.Dominio{
    public class Estaciones{
        [Required]
        [Display(Name="Id")]
        public int id {get;set;} 

        [Required]
        [Display(Name="Nombre")]
        public string nombre {get;set;}  

        [Required]
        [Display(Name="Direccion")]          
        public string direccion {get;set;}    

        [Required]
        [Display(Name="Coordenada X")]        
        public string coord_x {get;set;}    

        [Required]
        [Display(Name="Coordenada Y")]        
        public string coord_y {get;set;}   

        [Required]
        [Display(Name="Tipo")]         
        public string tipo {get;set;}            
           
    }
}