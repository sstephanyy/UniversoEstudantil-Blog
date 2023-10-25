using Microsoft.AspNetCore.Mvc;
using UniversoEstudantil.Data;
using UniversoEstudantil.Models.Domain;
using UniversoEstudantil.Models.ViewsModel;

namespace UniversoEstudantil.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDbContext _context;
        public BlogController(BlogDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Publicar(AddBlogRequest addBlogRequest)
        {
            var blogPost = new BlogPost
            {
                PageTitle = addBlogRequest.PageTitle,
                Content = addBlogRequest.Content,
                ShortDescription = addBlogRequest.ShortDescription,
                UrlImage = addBlogRequest.UrlImage,
                PublishedDate = addBlogRequest.PublishedDate,
                Author = addBlogRequest.Author,
                Visible = addBlogRequest.Visible
            };


            _context.BlogPosts.Add(blogPost);
            _context.SaveChanges();

            return RedirectToAction("Recentes");
        }

        [HttpGet]
        public IActionResult Recentes()
        {
            // Retrieve a list of blog posts from your database
            var blogPosts = _context.BlogPosts.ToList();

            return View(blogPosts);
        }

    }
}


