using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static alefbafilm6.Application.Services.Newsletter.Queries.GetNewsletter.GetNewsletterService;

namespace alefbafilm6.Application.Services.Newsletter.Queries.GetNewsletter
{
    public interface IGetNewsletterService
    {
        ResultGetNewsletterDto Execute();
    }
}
