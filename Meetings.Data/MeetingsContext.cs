using Microsoft.EntityFrameworkCore;

namespace Meetings.Data
{
    public class MeetingsContext : DbContext
    {
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}