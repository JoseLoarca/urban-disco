namespace AgendaIN6AV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int idUsuario { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name="Teléfono")]
        public int telefono { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Dirección")]
        public string direccion { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Nombre de Usuario")]
        public string username { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name="Contraseña"), DataType(DataType.Password)]
        public string password { get; set; }

        public int? idRol { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
