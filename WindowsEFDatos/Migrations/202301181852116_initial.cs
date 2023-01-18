namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avions",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacitdad = c.Int(nullable: false),
                        Denominacion = c.String(),
                        LineaAerea_IdLinea = c.Int(),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineaAereas", t => t.LineaAerea_IdLinea)
                .Index(t => t.LineaAerea_IdLinea);
            
            CreateTable(
                "dbo.LineaAereas",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avions", "LineaAerea_IdLinea", "dbo.LineaAereas");
            DropIndex("dbo.Avions", new[] { "LineaAerea_IdLinea" });
            DropTable("dbo.LineaAereas");
            DropTable("dbo.Avions");
        }
    }
}
