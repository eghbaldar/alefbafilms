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
            GetAboutPageDto about;
            var count = _context.Pages.Count();
            if(count > 0) {
                about = _context.Pages.Select(x => new GetAboutPageDto
                {
                    AboutPage = x.AboutPage,
                }).First();
            }
            else
            {
                return new GetAboutPageDto
                {
                    AboutPage = "اطلاعاتی برای نمایش وجود ندارد",
                };
            }
            return about;
        }
    }
}
