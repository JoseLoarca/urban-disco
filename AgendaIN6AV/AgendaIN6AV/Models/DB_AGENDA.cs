namespace AgendaIN6AV
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_AGENDA : DbContext
    {
        public DB_AGENDA()
            : base("name=DB_AGENDA")
        {
        }

        public virtual DbSet<Contacto> Contactoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.correoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
