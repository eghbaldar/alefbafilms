using alefbafilm6.Application.Services.Newsletter.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Interfaces.FacadePattern
{
    public  interface INewsletterFacade
    {
        PostNewsletterService PostNewsletterService { get; }
    }
}
