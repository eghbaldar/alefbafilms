using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Newsletter.Commands.PostNewsletter;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Site.Views.Shared.Components.Newsletter
{
    public class NewsletterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Index", new RequestNewsletterServiceDto
            {
                Email="",
            });
        }
    }
}
