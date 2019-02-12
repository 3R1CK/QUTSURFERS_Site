namespace QUTSurfers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'08fb75b0-d71f-4364-a69f-0ff63e0a96c8', N'erick.mejia.au@gmail.com', 0, N'ADjZaWCWrTv5nEH0iRUsduTdbbQ9rOGdLxPYiRuS0Wr+Z21oim8H+EQ1iE7KSU56PA==', N'd156d163-8f65-42d2-9c80-303ff97febfd', NULL, 0, 0, NULL, 1, 0, N'erick.mejia.au@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1e7d0a1c-9831-4532-8f75-eb951d1b4d85', N'admin@qutsurfers.com', 0, N'AJ5oiuDCGpjbJpXFhyQrAEzfSjMre+ysnncJ4H8OYyxMmdvEPbqljCbOJRuINdq3ow==', N'36dc28fd-b83d-4743-8fe9-83cad87e9af8', NULL, 0, 0, NULL, 1, 0, N'admin@qutsurfers.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c9655508-33ac-4f1e-8740-31f66da5d194', N'CanManageMembersAndEvents')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1e7d0a1c-9831-4532-8f75-eb951d1b4d85', N'c9655508-33ac-4f1e-8740-31f66da5d194')

");
        }
        
        public override void Down()
        {
        }
    }
}
