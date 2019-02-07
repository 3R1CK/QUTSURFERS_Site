namespace QUTSurfers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSurfingLevel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO LevelOfSurfings (Id, Name) VALUES (1, 'None')");
            Sql("INSERT INTO LevelOfSurfings (Id, Name) VALUES (2, 'Beginner')");
            Sql("INSERT INTO LevelOfSurfings (Id, Name) VALUES (3, 'Intermediate')");
            Sql("INSERT INTO LevelOfSurfings (Id, Name) VALUES (4, 'Advanced')");
        }
        
        public override void Down()
        {
        }
    }
}
