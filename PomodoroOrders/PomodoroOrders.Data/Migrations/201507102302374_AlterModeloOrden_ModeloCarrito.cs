namespace PomodoroOrders.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterModeloOrden_ModeloCarrito : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Carrito");
            DropColumn("dbo.Carrito", "IdCarrito");
            AddColumn("dbo.Carrito", "CarritoId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Orden", "IdAsociado", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Carrito", "CarritoId");
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carrito", "IdCarrito", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Carrito");
            DropColumn("dbo.Orden", "IdAsociado");
            DropColumn("dbo.Carrito", "CarritoId");
            AddPrimaryKey("dbo.Carrito", "IdCarrito");
        }
    }
}
