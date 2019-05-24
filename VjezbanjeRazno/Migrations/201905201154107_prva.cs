namespace MasterDetails.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seminars",
                c => new
                    {
                        SeminarId = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false),
                        Polozen = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SeminarId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false),
                        Prezime = c.String(),
                        SeminarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Seminars", t => t.SeminarId, cascadeDelete: true)
                .Index(t => t.SeminarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SeminarId", "dbo.Seminars");
            DropIndex("dbo.Students", new[] { "SeminarId" });
            DropTable("dbo.Students");
            DropTable("dbo.Seminars");
        }
    }
}
