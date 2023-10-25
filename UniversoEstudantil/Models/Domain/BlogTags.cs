namespace UniversoEstudantil.Models.Domain
{
    public class BlogTags
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; } // this will tell to entity framework that one tag can be in MULTIPLES Blogs. Many to many relationship table
    }
}
