using GeneralCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeneralCard.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"Top 3 JavaScript Frameworks","سه فریمورک معروف که دنیا را متحول میکند","blog-post-thumb-card-1.jpg"),
                new Article(2,"About Remote Working","کرونا چوگنه دنیا کسب و کار را متحول نمود ","blog-post-thumb-card-2.jpg"),
                new Article(3,"Full-Stack Developer","آیا برنامه نویسی به دوران افول خو نزدیک شده است","blog-post-thumb-card-3.jpg")
            };
            return View("_Articles",articles);
        }
    }
}
