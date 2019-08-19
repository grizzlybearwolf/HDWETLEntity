namespace HDWETLEntity.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Scheduling : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ETLScheduleLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProcessName = c.String(),
                        ExecuteStart = c.DateTime(nullable: false),
                        ExecuteEnd = c.DateTime(),
                        State = c.String(),
                        ETLScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ETLSchedules", t => t.ETLScheduleId, cascadeDelete: true)
                .Index(t => t.ETLScheduleId);
            
            CreateTable(
                "dbo.ETLSchedules",
                c => new
                    {
                        ETLScheduleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Period = c.Int(),
                        TriggerTime = c.DateTime(),
                        LastTriggered = c.DateTime(),
                        Frequency = c.Int(),
                    })
                .PrimaryKey(t => t.ETLScheduleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ETLScheduleLogs", "ETLScheduleId", "dbo.ETLSchedules");
            DropIndex("dbo.ETLScheduleLogs", new[] { "ETLScheduleId" });
            DropTable("dbo.ETLSchedules");
            DropTable("dbo.ETLScheduleLogs");
        }
    }
}
