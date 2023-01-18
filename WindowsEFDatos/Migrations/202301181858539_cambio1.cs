namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Avions", newName: "Avion");
            RenameTable(name: "dbo.LineaAereas", newName: "LineaAerea");
            AddColumn("dbo.Avion", "Capacidad", c => c.Int(nullable: false));
            AlterColumn("dbo.Avion", "Denominacion", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.LineaAerea", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropColumn("dbo.Avion", "Capacitdad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Avion", "Capacitdad", c => c.Int(nullable: false));
            AlterColumn("dbo.LineaAerea", "Nombre", c => c.String());
            AlterColumn("dbo.Avion", "Denominacion", c => c.String());
            DropColumn("dbo.Avion", "Capacidad");
            RenameTable(name: "dbo.LineaAerea", newName: "LineaAereas");
            RenameTable(name: "dbo.Avion", newName: "Avions");
        }
    }
}
