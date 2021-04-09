using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SitioWebBayronOrtiz.Models
{
    public class Contacto
    {
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
    }

    public class contactoContext : DbContext
    { 
        public DbSet<Contacto> Contactos { get; set; }
    }
}