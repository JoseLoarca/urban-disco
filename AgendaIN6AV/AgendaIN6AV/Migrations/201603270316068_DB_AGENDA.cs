namespace AgendaIN6AV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_AGENDA : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacto",
                c => new
                    {
                        idContacto = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 128, unicode: false),
                        telefono = c.Int(nullable: false),
                        correoElectronico = c.String(nullable: false, maxLength: 128, unicode: false),
                        direccion = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.idContacto);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        idRol = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.idRol);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        idUsuario = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 128, unicode: false),
                        telefono = c.Int(nullable: false),
                        direccion = c.String(nullable: false, maxLength: 128, unicode: false),
                        username = c.String(nullable: false, maxLength: 128, unicode: false),
                        password = c.String(nullable: false, maxLength: 128, unicode: false),
                        idRol = c.Int(),
                    })
                .PrimaryKey(t => t.idUsuario)
                .ForeignKey("dbo.Rol", t => t.idRol)
                .Index(t => t.idRol);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "idRol", "dbo.Rol");
            DropIndex("dbo.Usuario", new[] { "idRol" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Rol");
            DropTable("dbo.Contacto");
        }
    }
}
