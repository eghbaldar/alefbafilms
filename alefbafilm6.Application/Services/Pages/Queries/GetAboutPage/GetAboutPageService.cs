using alefbafilms.application.Interfaces.Contexts;

namespace alefbafilm6.Application.Services.Pages.Queries.GetAboutPage
{
    public class GetAboutPageService : IGetAboutPageService
    {
        private readonly IDataBaseContext _context;
        public GetAboutPageService(IDataBaseContext context)
        {
            _context = context;
        }
        public GetAboutPageDto Execute()
        {
            return _context.Pages.Select(x => new GetAboutPageDto
            {
                AboutPage = x.AboutPage,
            }).First();                    
        }
    }
}
