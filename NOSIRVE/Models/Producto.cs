using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NOSIRVE.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_prod { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesEnAlmacen { get; set; }
    }

    class ProductosDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
    }
}