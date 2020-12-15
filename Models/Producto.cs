using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practica03.Models
{
    [Table("productos")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }

        [Display(Name="Nombre del producto: ")]
        [Column("nombreProducto")]
        [Required(ErrorMessage="Porfavor ingrese un nombre")]
        public string nombreProducto { get; set; }

        [Display(Name="Descripcion: ")]
        [Column("descripcion")]
        [Required(ErrorMessage="Porfavor ingrese un nombre")]
        public string descripcion { get; set; }

        [Display(Name="Precio: ")]
        [Column("precio")]
        [Required(ErrorMessage="Porfavor ingrese un precio")]
        public double precio { get; set; }

        [Display(Name="Celular: ")]
        [Column("celular")]
        [Required(ErrorMessage="Porfavor ingrese un numero de celular")]
        public int celular { get; set; }

        [Display(Name="Direccion: ")]
        [Column("direccion")]
        [Required(ErrorMessage="Porfavor ingrese un numero de celular")]
        public string direccion { get; set; }

        [Display(Name="nombre de usuario: ")]
        [Column("nombreUsuario")]
        [Required(ErrorMessage="Porfavor ingrese un nombre de usuario")]
        public string nombreUsuario { get; set; }
        
    }

}
