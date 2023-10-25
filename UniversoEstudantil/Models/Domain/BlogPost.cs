namespace UniversoEstudantil.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; } // Guid -> unique identifier of ID
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string UrlImage { get; set; } 
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        public ICollection<BlogTags> BlogTags { get; set; } // this will tell to entity framework that one blog post can have MULTIPLES tags. Many to many relationship
    }
}
