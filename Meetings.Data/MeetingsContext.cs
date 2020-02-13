using Meetings.Domain;
using Microsoft.EntityFrameworkCore;

namespace Meetings.Data
{
    public class MeetingsContext : DbContext
    {
        public MeetingsContext(DbContextOptions<MeetingsContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("server=.\\SQL2017;database=meetings;Integrated Security=true;");

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}