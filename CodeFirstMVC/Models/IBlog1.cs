namespace CodeFirstMVC.Models
{
    public interface IBlog1
    {
        int BlogId { get; set; }
        string Name { get; set; }
        List<Post> Posts { get; set; }
    }
}