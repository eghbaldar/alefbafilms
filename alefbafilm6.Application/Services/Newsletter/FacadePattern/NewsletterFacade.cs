using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Newsletter.Commands.DeleteNewsletter;
using alefbafilm6.Application.Services.Newsletter.Commands.PostNewsletter;
using alefbafilm6.Application.Services.Newsletter.Queries.GetNewsletter;
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
        ///////////////////////////////////////////// GetNewsletterService
        private GetNewsletterService _getNewsletterService;
        public GetNewsletterService GetNewsletterService
        {
            get { return _getNewsletterService = _getNewsletterService ?? new GetNewsletterService(_context); }
        }
        ///////////////////////////////////////////// DeleteNewsletterService
        private DeleteNewsletterService _deleteNewsletterService;
        public DeleteNewsletterService DeleteNewsletterService
        {
            get { return _deleteNewsletterService = _deleteNewsletterService ?? new DeleteNewsletterService(_context); }
        }
    }
}
