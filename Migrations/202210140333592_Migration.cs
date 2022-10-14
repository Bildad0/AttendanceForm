namespace AttendanceForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceClasses",
                c => new
                    {
                        Attendance_id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Student_id = c.Int(nullable: false),
                        Lesson = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Attendance_id)
                .ForeignKey("dbo.Students", t => t.Student_id, cascadeDelete: true)
                .Index(t => t.Student_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AttendanceClasses", "Student_id", "dbo.Students");
            DropIndex("dbo.AttendanceClasses", new[] { "Student_id" });
            DropTable("dbo.AttendanceClasses");
        }
    }
}
