using ApiAspNetCoreServer.DataModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiAspNetCoreServer.DataModel
{
    public class TimetableContext : DbContext
    {
        public TimetableContext(DbContextOptions<TimetableContext> options) : base(options)
        { }

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherImage> TeacherImages { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Book>().HasOne(x => x.TeacherImage).WithOne().OnDelete(DeleteBehavior.Cascade);
            //base.OnModelCreating(builder);
        }
    }
}