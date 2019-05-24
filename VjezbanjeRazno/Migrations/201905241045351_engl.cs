namespace MasterDetails.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class engl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Seminars", "SeminarName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Students", "LastName", c => c.String());
            DropColumn("dbo.Seminars", "Naziv");
            DropColumn("dbo.Seminars", "Polozen");
            DropColumn("dbo.Students", "Ime");
            DropColumn("dbo.Students", "Prezime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Prezime", c => c.String());
            AddColumn("dbo.Students", "Ime", c => c.String(nullable: false));
            AddColumn("dbo.Seminars", "Polozen", c => c.Boolean(nullable: false));
            AddColumn("dbo.Seminars", "Naziv", c => c.String(nullable: false));
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Students", "Name");
            DropColumn("dbo.Seminars", "SeminarName");
        }
    }
}
