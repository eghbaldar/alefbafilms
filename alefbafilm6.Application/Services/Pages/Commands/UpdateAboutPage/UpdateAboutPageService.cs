using alefbafilm6.Domain.Entities.Pages;
using alefbafilms.application.Interfaces.Contexts;
using alefbafilms.Common.Dtos;

namespace alefbafilm6.Application.Services.Pages.Commands.PostAboutPage
{
    public class UpdateAboutPageService : IUpdateAboutPageService
    {
        private readonly IDataBaseContext _context;
        public UpdateAboutPageService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestUpdateAboutPageDto req)
        {
            Page aboutPage = new Page();
            aboutPage = _context.Pages.First();

            if(aboutPage == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "Nok",
                };
            }

            aboutPage.AboutPage = req.AboutPage;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "Ok",
            };
        }
    }
}
