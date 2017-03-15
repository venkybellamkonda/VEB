namespace CodeFirstMVC.Models
{
    public interface IPost
    {
        Blog Blog { get; set; }
        int BlogId { get; set; }
        string PostDate { get; set; }
        int PostId { get; set; }
        string Title { get; set; }
    }
}