namespace AgendaIN6AV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contacto")]
    public partial class Contacto
    {
        [Key]
        public int idContacto { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name="Tel�fono")]
        public int telefono { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Correo Electr�nico"), DataType(DataType.EmailAddress)]
        public string correoElectronico { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Direcci�n")]
        public string direccion { get; set; }
    }
}
