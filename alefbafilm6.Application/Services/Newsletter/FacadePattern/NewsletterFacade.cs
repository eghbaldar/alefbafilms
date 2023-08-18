using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Newsletter.Queries;
using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Newsletter.FacadePattern
{
    public class NewsletterFacade: INewsletterFacade
    {
        private readonly IDataBaseContext _context;
        public NewsletterFacade(IDataBaseContext context)
        {
            _context = context;
        }
        /////////////////////////////////////////// PostNewsletterService
        private PostNewsletterService _postNewsletterService;
        public PostNewsletterService PostNewsletterService
        {
            get { return _postNewsletterService = _postNewsletterService ?? new PostNewsletterService(_context); }
        }
    }
}
