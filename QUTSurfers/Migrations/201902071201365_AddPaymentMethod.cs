namespace QUTSurfers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentMethod : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Payments (Id, Name) VALUES (1, 'Cash') ");
            Sql("INSERT INTO Payments (Id, Name) VALUES (2, 'Credit Card') ");
            Sql("INSERT INTO Payments (Id, Name) VALUES (3, 'PayPal') ");
        }
        
        public override void Down()
        {
        }
    }
}
