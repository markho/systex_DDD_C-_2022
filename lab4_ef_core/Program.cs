using Model;
using var db = new BlogContext();
Console.WriteLine($"資料庫的路徑是:{db.DbPath}");

db.Add(new Blog { Uri = "http://www.uuu.com.tw/" });
db.Add(new Blog { Uri = "http://www.tibame.com/" });
db.Add(new Blog { Uri = "http://hahow.in/" });
db.SaveChanges();
Console.WriteLine("將資料讀回");
var blogs = db.Blogs!.OrderBy(b => b.BlogId);
foreach (var b in blogs)
{
    Console.WriteLine($"{b.BlogId},{b.Uri}");
}