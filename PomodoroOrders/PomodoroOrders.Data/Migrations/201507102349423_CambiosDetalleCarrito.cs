namespace PomodoroOrders.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosDetalleCarrito : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetalleCarrito", "CarritoId", c => c.Int(nullable: false));
            AddColumn("dbo.DetalleCarrito", "ProductoId", c => c.Int(nullable: false));
            DropColumn("dbo.DetalleCarrito", "IdCarrito");
            DropColumn("dbo.DetalleCarrito", "IdProducto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetalleCarrito", "IdProducto", c => c.Int(nullable: false));
            AddColumn("dbo.DetalleCarrito", "IdCarrito", c => c.Int(nullable: false));
            DropColumn("dbo.DetalleCarrito", "ProductoId");
            DropColumn("dbo.DetalleCarrito", "CarritoId");
        }
    }
}
