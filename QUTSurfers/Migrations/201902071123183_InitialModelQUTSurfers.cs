namespace QUTSurfers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModelQUTSurfers : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.String(nullable: false, maxLength: 255),
                        StudentNumber = c.String(),
                        IntlStudent = c.Boolean(nullable: false),
                        SurfingLevelId = c.Byte(nullable: false),
                        PaymentTypeId = c.Byte(nullable: false),
                        PaymentApproval = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.PaymentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.LevelOfSurfings", t => t.SurfingLevelId, cascadeDelete: true)
                .Index(t => t.SurfingLevelId)
                .Index(t => t.PaymentTypeId);
            
            CreateTable(
                "dbo.LevelOfSurfings",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Payments",
                    c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SurfingLevels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAdded = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.String(nullable: false, maxLength: 255),
                        StudentNumber = c.String(),
                        IntlStudent = c.Boolean(nullable: false),
                        SurfingLevelId = c.Byte(nullable: false),
                        PaymentMethodId = c.Byte(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Members", "SurfingLevelId", "dbo.LevelOfSurfings");
            DropForeignKey("dbo.Members", "PaymentTypeId", "dbo.Payments");
            DropIndex("dbo.Members", new[] { "PaymentTypeId" });
            DropIndex("dbo.Members", new[] { "SurfingLevelId" });
            DropTable("dbo.LevelOfSurfings");
            DropTable("dbo.Members");
            CreateIndex("dbo.Students", "SurfingLevelId");
            AddForeignKey("dbo.Students", "SurfingLevelId", "dbo.SurfingLevels", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Payments", newName: "PaymentMethods");
        }
    }
}
