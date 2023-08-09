using alefbafilm6.Application.Interfaces.FacadePattern;
using alefbafilm6.Application.Services.Pages.Commands.PostAboutPage;
using alefbafilms.application.Interfaces.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alefbafilm6.Application.Services.Pages.FacadePattern
{
    public class PagesFacade:IPagesFacade
    {
        ////////////////////////////////////////////////////////// Context
        private readonly IDataBaseContext _context;
        public PagesFacade(IDataBaseContext context)
        {
            _context = context;
        }
        ////////////////////////////////////////////////////////// 
        private UpdateAboutPageService _updateAboutPageService;
        public UpdateAboutPageService UpdateAboutPageService
        {
            get { return _updateAboutPageService = _updateAboutPageService ?? new UpdateAboutPageService(_context); }
        }
    }
}
