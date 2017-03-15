using System.Collections.Generic;

namespace CodeFirstMVC.Models
{
    public interface IBlog
    {
        int BlogId { get; set; }
        int BlogId { get; set; }
        string Name { get; set; }
        string Name { get; set; }
        List<Post> Posts { get; set; }
        List<Post> Posts { get; set; }
    }
}