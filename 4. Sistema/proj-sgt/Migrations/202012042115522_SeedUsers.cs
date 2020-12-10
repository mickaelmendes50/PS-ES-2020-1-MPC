namespace proj_sgt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'55fb9f0a-df31-4c8c-9784-ae3ca0794f0c', N'Kaio', N'membro@sgt.com', 0, N'ABZcqN9zAwVJ9fd0uYNJM/GZ9ONBnOfe0StrHnz0O0Z9DfvT2EV8JzeOAEatcEbP2w==', N'ac70b8c3-5eb3-4fe7-97f4-149d801f275c', NULL, 0, 0, NULL, 1, 0, N'membro@sgt.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'63ba71a1-a105-49c1-a98c-fff8e2c2a31d', N'Gustavo', N'diretor@sgt.com', 0, N'AEj5EWe3ZJsDg50OPQEkj14oB/QG2lUVGrDB6ezhngj8rrQqsLm3b57z9+sFIJONQA==', N'1457c888-0552-42dd-905a-3df37933c80e', NULL, 0, 0, NULL, 1, 0, N'diretor@sgt.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e9299426-1c86-4b26-b7e8-e4d180318ef7', N'Miccael', N'orientador@sgt.com', 0, N'AJ2tX8Abr5jCKdwrU8vWyTAN2TEEBxM5PQsSIRemJA0U1vt1/Ioox8ETBYu0YMlIbg==', N'4c92072c-2a91-4d37-8022-3c28cc58a67c', NULL, 0, 0, NULL, 1, 0, N'orientador@sgt.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ef3104ea-efa7-4fa6-b252-586fe6db8c8a', N'Diretor')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'72147598-86e2-4f3a-9b04-393562244ebf', N'Membro')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd2957031-74b6-4604-a927-e49f9e7cc000', N'Orientador')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'55fb9f0a-df31-4c8c-9784-ae3ca0794f0c', N'72147598-86e2-4f3a-9b04-393562244ebf')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9299426-1c86-4b26-b7e8-e4d180318ef7', N'd2957031-74b6-4604-a927-e49f9e7cc000')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'63ba71a1-a105-49c1-a98c-fff8e2c2a31d', N'ef3104ea-efa7-4fa6-b252-586fe6db8c8a')

            
            ");
        }
        
        public override void Down()
        {
        }
    }
}
