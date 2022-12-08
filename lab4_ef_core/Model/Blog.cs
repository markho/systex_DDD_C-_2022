namespace Model;
public class Blog
{
    public int BlogId { get; set; }
    public string? Uri { get; set; }
    public List<Post> Posts { get; set; } = new();
}