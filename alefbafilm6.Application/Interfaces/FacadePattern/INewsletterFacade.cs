using alefbafilm6.Application.Services.Newsletter.Commands.DeleteNewsletter;
using alefbafilm6.Application.Services.Newsletter.Commands.PostNewsletter;
using alefbafilm6.Application.Services.Newsletter.Queries.GetNewsletter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public interface INewsletterFacade
    {
        PostNewsletterService PostNewsletterService { get; }
        GetNewsletterService GetNewsletterService { get; }
        DeleteNewsletterService DeleteNewsletterService { get; }
    }
}
