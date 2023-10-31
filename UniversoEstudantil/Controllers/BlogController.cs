using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using UniversoEstudantil.Data;
using UniversoEstudantil.Models.Domain;
using UniversoEstudantil.Models.ViewsModel;

namespace UniversoEstudantil.Controllers
{

    [Authorize] //somente users autorizados podem acessar esse controller
    public class BlogController : Controller
    {
        private readonly BlogDbContext _context;
        public BlogController(BlogDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Adicionar()
        {
            return View();
        }

        //create a blog post
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

        //send this created post to "Recentes" page
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Recentes()
        {
            // Retrieve a list of blog posts from your database
            var blogPosts = _context.BlogPosts.ToList();

            return View(blogPosts);
        }

        [HttpGet("Blog/Post/{id}")]
        [Authorize(Roles = "User, Admin, Gerente")]
        public IActionResult Post([FromRoute] string id)  // pegar o post com base no id
        {
            if (Guid.TryParse(id, out Guid idGuid))
            {
                // A conversão de id para Guid foi bem-sucedida, agora podemos comparar com o campo Id
                var post = _context.BlogPosts.FirstOrDefault(p => p.Id == idGuid);

                if (post != null)
                {
                    // O post foi encontrado com base no Id
                    return View(post);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound("Erro de Conversao");
            }
        }


    }
}


