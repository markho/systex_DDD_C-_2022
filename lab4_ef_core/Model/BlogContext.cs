using Microsoft.EntityFrameworkCore;

namespace Model;
public class BlogContext : DbContext
{
    public BlogContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "lab4.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

    public DbSet<Blog>? Blogs { get; set; }
    public DbSet<Post>? Posts { get; set; }
    public string DbPath { get; }

}