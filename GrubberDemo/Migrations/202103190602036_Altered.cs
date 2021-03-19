namespace GrubberDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Altered : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "Mobile", c => c.String());
            DropColumn("dbo.Employees", "Gender");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "Role");
            DropColumn("dbo.Employees", "Skills");
            DropColumn("dbo.Employees", "About");
            DropColumn("dbo.Employees", "BirthDate");
            DropColumn("dbo.Employees", "JoinDate");
            DropColumn("dbo.Employees", "Hobbies");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Hobbies", c => c.String());
            AddColumn("dbo.Employees", "JoinDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "About", c => c.String());
            AddColumn("dbo.Employees", "Skills", c => c.String());
            AddColumn("dbo.Employees", "Role", c => c.String());
            AddColumn("dbo.Employees", "Address", c => c.String(maxLength: 1000));
            AddColumn("dbo.Employees", "Gender", c => c.String());
            DropColumn("dbo.Employees", "Mobile");
            DropColumn("dbo.Employees", "Email");
        }
    }
}
