namespace UniversoEstudantil.Models.ViewsModel
{
    public class AddBlogRequest
    {
        public string PageTitle { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string UrlImage { get; set; } 

        public DateTime PublishedDate { get; set; } 
        public string Author { get; set; } = string.Empty;
        public bool Visible { get; set; }
    }
}
