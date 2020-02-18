namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4d61bb94-ca3f-42e0-934d-30fb5c9ccfaf', N'admin@vidly.com', 0, N'ADj57AsriBgw27LzX4+9nWxUXWgdYx1EPrZ6EORm2p2A2A9j/RXeEknaNbL5Yt483g==', N'078add2b-d7ba-4e9e-b688-dd6db5bad3d1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'edd43bc5-bc3f-4459-bb07-2fecee131c18', N'guest@vidly.com', 0, N'AMF4e0RTamYVYkRLYP97G95V79pkeFePQbSqSVk0QYbdwdwShLaZN0dFGJE7NtojoA==', N'9a1e3cfc-476b-4402-b261-53fe21f5d104', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1e831306-7430-4422-99bc-dbb9f8ed4aa6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4d61bb94-ca3f-42e0-934d-30fb5c9ccfaf', N'1e831306-7430-4422-99bc-dbb9f8ed4aa6')
");
        }
        
        public override void Down()
        {
        }
    }
}
