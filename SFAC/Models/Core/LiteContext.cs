using Microsoft.EntityFrameworkCore;
using SFAC.Models.Room;

namespace SFAC.Models.Core
{
    public class LiteContext : DbContext
    {
        public DbSet<Room_Model> room_Models { get; set; }
        public string DbPath { get; }
        public LiteContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "SFAC.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
